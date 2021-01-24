using System;

namespace OOP1
{
    class Program
    {
        //nesne yönelimli proje
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            //Farklı yazılış yöntemi.
            Product product2 = new Product {Id=2,CategoryId=5,UnitInStock=5,ProductName="Kalem",UnitPrice=35};

            //PascalCase -Kelimelerin ilk harf büyük     //camelCase - İlk kelimenin ilk harfi küçük sonraki kelime büyük yazılış şekli.
            //case sensitive -Küçük büyük harf duyarlı.
            ProductManager productManager = new ProductManager();
            productManager.Add(product1.ProductName);

            //int ,double,bool .... sayısallar değer tip
            //diziler,class,abstract class,interface.... referans tip



        }
    }
}
