using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            //class tanımı
            kurs kurs1 = new kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;


            kurs kurs3 = new kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin ";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            //içinde kurslar olan bir array tanımı sadece metin olmadığı için string yapmadık
            kurs[] kurslar = new kurs[] { kurs1,
            kurs2,kurs3};

            //Döngü ile döndüreceğiz
            foreach (var kurs  in kurslar)  
            {
                Console.WriteLine(kurs.KursAdi + ": "+ kurs.Egitmen);
            }
                

            Console.WriteLine("Hello World!");
        }
    }

    class kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
