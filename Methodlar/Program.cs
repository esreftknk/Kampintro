using System;

namespace Methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string Adi = "elma";
            double Fiyati = 15;
            string Aciklama = "Amasya Elması";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması.";
            urun1.StokAdedi = 5;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.StokAdedi = 10;

            Urun[] Urunler = new Urun[] {urun1,urun2 };

            //var da yazsak olur. Urun diyede yazılabilir.
            foreach (Urun Urun in Urunler)
            {
                Console.WriteLine(Urun.Adi);
                Console.WriteLine(Urun.Fiyati);
                Console.WriteLine(Urun.Aciklama);
                Console.WriteLine(Urun.StokAdedi);
                Console.WriteLine("------------------");
            }
            //Cw tab tab hızlı yazım
            Console.WriteLine("------------------Methotlar----------------");

            //instance-Örnek
            //encapsulation -

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", 15, "Yeşil Armut",8);
            sepetManager.Ekle2("Elma", 15, "Yeşil Armut",5);
            sepetManager.Ekle2("Karpuz", 15, "Diyarbakır karpuzu",7);


        }
    }
}

// Methodlar= Tekrar Tekrar yazılacak işlemleri teke cevirmek için
//Do not repeat yourself -DRY- Clean Code -Best Practice
//temel yapılar class içinde olur.