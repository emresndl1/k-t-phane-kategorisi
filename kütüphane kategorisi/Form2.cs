using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphane
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            int nextId = Database.UrunTablo.Any() ? Database.UrunTablo.Max(u => u.id) + 1 : 1;


            Urun newUrun = new Urun()
            {
                id = nextId,
                urunAdi = txtUrnad.Text,
                stokAdet = (int)txtStok.Value,
                urunKategori = txtKater.Text,
                aciklama = txtAçıklama.Text,
                yazar = txtYazar.Text,
                urunResim = txtUrunResim.Text
            };


            Database.UrunTablo.Add(newUrun);


            txtUrnad.Clear();
            txtStok.Value = 0;
            txtKater.Clear();
            txtAçıklama.Clear();
            txtYazar.Clear();
            txtUrunResim.Clear();

            MessageBox.Show("Ürün başarıyla eklendi!");
        }


        private void button_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}

