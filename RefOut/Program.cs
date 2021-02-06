using System;

namespace RefOut
{
    class Program
    {

        //Değerleri referans tiplere çevirmek için ref komutu kullanır.
        static void Main(string[] args)
        {
            //int number1 = 20;
            //int number2 = 100;
            //var result = Add3(ref number1, number2);
            //Console.WriteLine(result);
            //Console.WriteLine(number1);
           
            //static int Add3(ref int number1,int number2)
            //{
            //    number1 = 30;
            //    return number1 + number2;

            //}

            //Out Kullanım
            int number1 ;
            int number2 = 100;
            var result = Add3(out number1, number2);
            Console.WriteLine(result);
            Console.WriteLine(number1);

            static int Add3(out int number1, int number2)
            {
                number1 = 30;
                return number1 + number2;

            }
        }
    }
}
