using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSessionWindowsOOP.Props
{
    class Car
    {
        public Car(int maxHiz)
        {
            limitHiz = maxHiz;
        }
        //Field
        int anlikHiz;
        int limitHiz;
        //Property
        //get fonksiyonu değer döndürür
        //set fonksiyonu ise değer ataması yapar


        public int LimitHiz { get { return limitHiz; } }
        public int AnlikHiz
        {
            get { return anlikHiz; }
            set
            {
                if (value > 100)
                {
                    anlikHiz = 100;
                }
                else if (value < 0)
                {
                    anlikHiz = 0;
                }
                else
                {
                    anlikHiz = value;
                }
            }
        }
        public void GazaBas()
        {
            AnlikHiz += 40;
        }
        public void Frenle()
        {
            AnlikHiz -= 40;
        }
    }
}
