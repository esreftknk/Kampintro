using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        //parantez içi parametre
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Tebrikler.Müşteri eklendi : "+ musteri.Name);
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Tebrikler.Müşteri silindi:" + musteri.Name);
        }

        public void Update(Musteri musteri)
        {
            Console.WriteLine("Tebrikler.Müşteri eklendi :"+ musteri.Name);
        }
    }
}

