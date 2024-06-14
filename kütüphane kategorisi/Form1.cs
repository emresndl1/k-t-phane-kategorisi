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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //comboBoxDoldurv1();
            comboBoxDoldurv2();

        }

        private void comboBoxDoldurv2()
        {
            cmburunListe.DataSource = Database.UrunTablo;
        }


        void comboBoxDoldurV1()
        {
            foreach (var item in Database.UrunTablo)
            {
                cmburunListe.Items.Add(item);
            }

            
        }

        private void cmburunListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            object o1 = cmburunListe.SelectedItem;

            Urun u1 = (Urun)o1;


            pctUrunResim.Image = Image.FromFile(u1.urunResim);
            pctUrunResim.SizeMode = PictureBoxSizeMode.StretchImage;


            txtUrunAdi.Text = u1.urunAdi;
            txtKategori.Text = u1.urunKategori;
            txtStok.Text = u1.stokAdet.ToString();
            txtYazar.Text = u1.yazar;
            txtUrunAciklama.Text = u1.aciklama;

        }
    }
}
