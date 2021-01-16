using System;
using System.Collections.Generic;
using System.Text;

namespace Methodlar
{
    class SepetManager
    {
        // Naming Convention  -()-Method olduğunu belirtiyor.
        //Syntax 
        public void Ekle (Urun urun)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi:"+ urun.Adi);

        }

        public void Ekle2(string urunAdi,double fiyat,string Aciklama,int stokAdedi)
        {
            Console.WriteLine("Tebrikler :Sepete eklendi!" + urunAdi);
        }
    }
}
