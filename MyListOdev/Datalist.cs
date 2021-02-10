using System;
using System.Collections.Generic;
using System.Text;

namespace MyListOdev
{

    //Array tutma ve yönetme
    
    class Datalist <T>
    {
        T[] items;
        //Constructor
        public Datalist()
        {
            items = new T[0];

        }

        //T key değerini dinamik artırma kodu
        public void  Add (T item)
        {
            T[] tempArray = items;
            items = new T[items.Length+1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;

        }

    }
}
