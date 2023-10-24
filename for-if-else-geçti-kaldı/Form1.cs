using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_if_else_geçti_kaldı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lslNotlar.Items.Clear();
            Random rnd = new Random();

            for (int i = 1; i <= 40; i++)
            {
                lslNotlar.Items.Add(rnd.Next(1, 101));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lslKalanlar.Items.Clear();
            lslGecenler.Items.Clear();
            int not;
            int gecenSayisi = 0;
            int kalanSayisi = 0;
            int tesekkurSayisi = 0;
            int takdirSayisi = 0;
            int duzGecen = 0;

            int enYuksekPuan = 0;

            int enDusukPuan = 100;

            double sinifToplam = 0;
            double sinifOrtalama = 0;


            for (int i = 0; i < lslNotlar.Items.Count; i++)
            {
                not = Convert.ToInt32(lslNotlar.Items[i]);

                if (not >= 50)
                {
                    lslGecenler.Items.Add(not);
                    gecenSayisi++;
                }
                else
                {
                    lslKalanlar.Items.Add(not);
                    kalanSayisi++;
                }
                if (not >= 70 && not < 85)
                {
                    tesekkurSayisi++;
                }
                if (not >= 85)
                {
                    takdirSayisi++;
                }
                if (not >= 50 && not < 70)
                {
                    duzGecen++;
                }


                if (not > enYuksekPuan)
                {
                    enYuksekPuan = not;
                }

                if (not < enDusukPuan)
                {
                    enDusukPuan = not;
                }
                sinifToplam += not;
                sinifOrtalama += sinifToplam;



                lblGecenler.Text = "Geçen: " + gecenSayisi;
                lblKalanlar.Text = "Kalan: " + kalanSayisi;
                lblTesekkür.Text = "Teşekkür Belgesi: " + tesekkurSayisi;
                lblTakdir.Text = "Takdir Belgesi. " + takdirSayisi;
               lblDüz.Text = "Belge Almadan Geçen: " + duzGecen;
                lblYüksek.Text = "En Yüksek Not: " + enYuksekPuan;
                lblDüsük.Text = "En Düşük Not: " + enDusukPuan;
                lblSinif.Text = "Sınıf Ortalaması:" +sinifOrtalama;



            }
        }
    }
}
