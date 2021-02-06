using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Name = "Eşref";
            musteri1.Surname = "Tekinok";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Name = "Engin ";
            musteri2.Surname = "Demiroğ";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (var musteri in musteriler)
            {
                //Console.WriteLine(musteri.Id);
                //Console.WriteLine("Sayın : "+musteri.Name + musteri.Surname);
                Console.WriteLine("***************************************");
            }
            //instance-Örnek
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Delete(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Update(musteri1);
        }
    }
}
