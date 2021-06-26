using System;
using System.Collections.Generic;
using System.Text;

namespace ButikSinemaUygulamasi
{
    class Uygulama
    {

        Sinema Snm;

        public void Calistir()
        {
            Kurulum();
            Menu();
            while (true)
            {
               string secim = SecimAl();
                switch (secim)
                {
                    case "1":
                    case "S":
                        Snm.BiletSatisi();
                        break;
                    case "2":
                    case "R":
                        Snm.BiletIadesi();
                        break;
                    case "3":
                    case "D":
                        DurumBilgisi();
                        break;
                    case "4":
                    case "X":
                        Environment.Exit(0);
                        break;
                } 
            }
            

        }

        public void Kurulum()
        {
            Console.WriteLine("-------Butik Sinema Salonu-------");
            Console.Write("Film adı:");
            string ad = Console.ReadLine();
            Console.Write("Kapasite:");
            int kapasite = int.Parse(Console.ReadLine());
            Console.Write("Tam Bilet Fiyatı:");
            float tam_fiyat = float.Parse(Console.ReadLine());
            Console.Write("Yarım Bilet Fiyatı:");
            float yarim_fiyat = float.Parse(Console.ReadLine());

            Snm = new Sinema(ad,kapasite,tam_fiyat,yarim_fiyat);

        }

        public void Menu()
        {
            Console.WriteLine("1 - Bilet Sat(S)     ");
            Console.WriteLine("2 - Bilet İade(R)    ");
            Console.WriteLine("3 - Durum Bilgisi(D) ");
            Console.WriteLine("4 - Çıkış(X)         ");
            Console.WriteLine();
        }

        public string SecimAl()
        {
            Console.Write("Seçiminiz: ");
            return Console.ReadLine().ToUpper();
        }


        public void DurumBilgisi()
        {
            
            Console.WriteLine("Durum Bilgisi"); 
            Console.WriteLine("Film: " + Snm.FilmAdi); 
            Console.WriteLine("Kapasite: "+ Snm.Kapasite); 
            Console.WriteLine("Tam Bilet Fiyatı : " +Snm.TamBiletFiyati); 
            Console.WriteLine("Yarım Bilet Fiyatı : "+Snm.YarimBiletFiyati); 
            Console.WriteLine("Toplam Tam Bilet Adedi : "+Snm.ToplamTamBiletAdedi); 
            Console.WriteLine("Toplam Yarım Bilet Adedi : "+Snm.ToplamYarimBiletAdedi); 
            Console.WriteLine("Ciro: " + Snm.Ciro); 
            Console.WriteLine("Boş Koltuk Adedi: " + Snm.BosKoltukAdedi()); 

        }



    }
}
