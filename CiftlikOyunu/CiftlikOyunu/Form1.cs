using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CiftlikOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        keci keci = new keci();
        ordek ordek = new ordek();
        inek inek = new inek();
        tavuk tavuk = new tavuk();
        int saniye, kasa;
        private void Form1_Load(object sender, EventArgs e)
        {
            timersüre.Enabled = true;
        }

        private void timersüre_Tick(object sender, EventArgs e)
        {
            saniye++;
            labelsaniye.Text = saniye + " SN";
            if (tavuk.yasam==false&&ordek.yasam==false&&keci.yasam==false&&inek.yasam==false)
            {
                timersüre.Stop();
            }

            if (progressBartavuk.Value - tavuk.canAzalmaMiktari<= 0)
            {
                progressBartavuk.Enabled = false;
                labelTavukCanlıÖlü.Text = "ÖLDÜ";
                progressBartavuk.Value = 0;
                if (tavuk.yasam == true)
                {
                    tavuk.sesCikart();
                    tavuk.yasam = false;
                }
            }
            else 
            {
                if (progressBartavuk.Enabled == true)
                {
                    progressBartavuk.Value -=tavuk.canAzalmaMiktari ;
                    if (saniye % tavuk.urunSuresi == 0)
                    {
                        tavuk.urun++;
                        labeltavukYumurtaAdet.Text = Convert.ToString(tavuk.urun) + " ADET";
                    }
                }
            }


            if (progressBarördek.Value - ordek.canAzalmaMiktari <= 0)
            {
                progressBarördek.Enabled = false;
                labelOrdekCanlıÖlü.Text = "ÖLDÜ";
                progressBarördek.Value = 0;
                if (ordek.yasam == true)
                {
                    ordek.sesCikart();
                    ordek.yasam = false;
                }
            }
            else
            {
                if (progressBarördek.Enabled == true)
                {
                    progressBarördek.Value -= ordek.canAzalmaMiktari;
                    if (saniye % ordek.urunSuresi == 0)
                    {
                        ordek.urun++;
                        labelordekYumurtaAdet.Text = Convert.ToString(ordek.urun) + " ADET";
                    }
                }
            }

            if (progressBarinek.Value - inek.canAzalmaMiktari <= 0)
            {
                progressBarinek.Enabled = false;
                labelİnekCanlıÖlü.Text = "ÖLDÜ";
                progressBarinek.Value = 0;
                if (inek.yasam == true)
                {
                    inek.sesCikart();
                    inek.yasam = false;
                }
            }
            else
            {
                if (progressBarinek.Enabled == true)
                {
                    progressBarinek.Value -= inek.canAzalmaMiktari;
                    if (saniye % inek.urunSuresi == 0)
                    {
                        inek.urun++;
                        labelinekSutKg.Text = Convert.ToString(inek.urun) + " KG";
                    }
                }
            }

            if (progressBarkeci.Value - keci.canAzalmaMiktari <= 0)
            {
                progressBarkeci.Enabled = false;
                labelKeciCanlıÖlü.Text = "ÖLDÜ";
                progressBarkeci.Value = 0;
                if (keci.yasam == true)
                {
                    keci.sesCikart();
                    keci.yasam = false;
                }
            }
            else
            {
                if (progressBarkeci.Enabled == true)
                {
                    progressBarkeci.Value -= keci.canAzalmaMiktari;
                    if (saniye % keci.urunSuresi == 0)
                    {
                        keci.urun++;
                        labelkeciSutuKg.Text = Convert.ToString(keci.urun) + " KG";
                    }
                }
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            kasa += tavuk.urun*tavuk.urunFiyati;
            tavuk.urun = 0;
            labelkasa.Text = Convert.ToString(kasa) + " TL";
            labeltavukYumurtaAdet.Text = "0 ADET";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kasa += ordek.urun*ordek.urunFiyati;
            ordek.urun = 0;
            labelkasa.Text = Convert.ToString(kasa) + " TL";
            labelordekYumurtaAdet.Text = "0 ADET";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kasa += inek.urun * inek.urunFiyati;
            inek.urun = 0;
            labelkasa.Text = Convert.ToString(kasa) + " TL";
            labelinekSutKg.Text = "0 KG";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kasa += keci.urun * keci.urunFiyati;
            keci.urun = 0;
            labelkasa.Text = Convert.ToString(kasa) + " TL";
            labelkeciSutuKg.Text = "0 KG";

        }

        private void btn_yemvertavuk_Click(object sender, EventArgs e)
        {
            if (tavuk.yasam == true)
            {
                progressBartavuk.Value = 100;
            }

        }

        private void btn_yemverördek_Click(object sender, EventArgs e)
        {
            if (ordek.yasam == true)
            {
                progressBarördek.Value = 100;
            }

        }

        private void btn_yemverinek_Click(object sender, EventArgs e)
        {
            if (inek.yasam == true)
            {
                progressBarinek.Value = 100;
            }

        }

        private void btn_yemverkeci_Click(object sender, EventArgs e)
        {
            if (keci.yasam == true)
            {
                progressBarkeci.Value = 100;
            }

        }
    }
}
