using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace CiftlikOyunu
{
    public abstract class hayvan
    { 
        public bool yasam = true;
        public int urun = 0;
    }
    public class tavuk : hayvan
    {
        public int canAzalmaMiktari = 2; 
        public int urunSuresi = 3; 
        public int urunFiyati = 1; 

        public void sesCikart()
        {
            SoundPlayer ses = new SoundPlayer();
            ses.SoundLocation = "tavuk.wav";
            ses.Play();
        }
    }
    public class ordek : hayvan
    {
        public int canAzalmaMiktari = 3;
        public int urunSuresi = 5;
        public int urunFiyati = 3;

        public void sesCikart()
        {
            SoundPlayer ses = new SoundPlayer();
            ses.SoundLocation = "ordek.wav";
            ses.Play();
        }
    }
    public class inek : hayvan
    {
        public int canAzalmaMiktari = 8;
        public int urunSuresi = 8;
        public int urunFiyati = 5;

        public void sesCikart()
        {
            SoundPlayer ses = new SoundPlayer();
            ses.SoundLocation = "inek.wav";
            ses.Play();
        }
    }
    public class keci : hayvan
    {
        public int canAzalmaMiktari = 6;
        public int urunSuresi = 7;
        public int urunFiyati = 8;

        public void sesCikart()
        {
            SoundPlayer ses = new SoundPlayer();
            ses.SoundLocation = "keci.wav";
            ses.Play();
        }
    }
}
