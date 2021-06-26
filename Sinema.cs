using System;
using System.Collections.Generic;
using System.Text;

namespace ButikSinemaUygulamasi
{
    class Sinema
    {
        public string FilmAdi;
        public int Kapasite;
        public float TamBiletFiyati;
        public float YarimBiletFiyati;
        public int ToplamTamBiletAdedi;
        public int ToplamYarimBiletAdedi;
        public float Ciro;

        //constructors
        public Sinema(string film_adi,int kapasite, float tam_bilet_fiyati, float yarim_bilet_fiyati)
        {
            this.FilmAdi = film_adi;
            this.Kapasite = kapasite;
            this.TamBiletFiyati = tam_bilet_fiyati;
            this.YarimBiletFiyati = yarim_bilet_fiyati;
            this.ToplamTamBiletAdedi = 0;
            this.ToplamYarimBiletAdedi = 0;
        }

        public void BiletSatisi()
        {
            Console.WriteLine("Bilet satisi");
            System.Console.WriteLine("1. Tam bilet satışı");
            System.Console.WriteLine("2. Yarım bilet satışı");
            System.Console.Write("Seçim: ");
            string secim = Console.ReadLine();
            int adet;
            if(secim == "1")
            {
            
                System.Console.Write("Adet: ");
                adet = int.Parse(Console.ReadLine());
                if(this.BosYerVarMi(adet))
                    TamBiletSatisi(adet);
                else
                    System.Console.WriteLine("Yeteri kadar boş yer yok..");
            }
            else if(secim == "2")
            {
                System.Console.Write("Adet: ");
                adet = int.Parse(Console.ReadLine());
                YarimBiletSatisi(adet);
            }
            else
                System.Console.WriteLine("Hatalı seçim");
            
            
            this.CiroHesapla();

        }

        public bool BosYerVarMi(int adet)
        {
            if(this.BosKoltukAdedi()< adet)
                return false;
            return true;
        }

        public int BosKoltukAdedi()
        {
            return this.Kapasite - this.ToplamTamBiletAdedi - this.ToplamYarimBiletAdedi;
        }


        public void CiroHesapla()
        {
            this.Ciro = this.TamBiletFiyati*this.ToplamTamBiletAdedi + this.YarimBiletFiyati*this.ToplamYarimBiletAdedi;
        }

        public void TamBiletSatisi(int adet)
        {
            this.ToplamTamBiletAdedi += adet;

        }
        public void YarimBiletSatisi(int adet)
        {
            this.ToplamYarimBiletAdedi += adet;

        }

        public bool IadeEdilirMiTamBilet(int adet)
        {
            if(this.ToplamTamBiletAdedi < adet)
                return false;
            return true;
        }
        public bool IadeEdilirMiYarimBilet(int adet)
        {
            if(this.ToplamYarimBiletAdedi < adet)
                return false;
            return true;
        }

        public void BiletIadesi()
        {
            Console.WriteLine("Bilet iadesi");
            System.Console.WriteLine("1. Tam bilet iadesi");
            System.Console.WriteLine("2. Yarım bilet iadesi");
            System.Console.Write("Seçim: ");
            string secim = Console.ReadLine();
            int adet;
            if(secim == "1")
            {
                System.Console.Write("Adet: ");
                adet = int.Parse(Console.ReadLine());
                if(this.IadeEdilirMiTamBilet(adet))
                    TamBiletSatisi(-1*adet);
                else
                    System.Console.WriteLine("Dolandırıcı var");
            }
            else if(secim == "2")
            {
                System.Console.Write("Adet: ");
                adet = int.Parse(Console.ReadLine());
                if(this.IadeEdilirMiYarimBilet(adet))
                    YarimBiletSatisi(-1*adet);
                else
                    System.Console.WriteLine("Dolandırıcı var");
            }
            else
                System.Console.WriteLine("Hatalı seçim");
            
            this.CiroHesapla();
            
        }

    }
}
