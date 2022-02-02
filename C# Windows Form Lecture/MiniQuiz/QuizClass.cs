using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSessionWindowsOOP.MiniQuiz
{
    class QuizClass
    {
        public QuizClass(string isim)
        {
            name = isim;
      
        }

        public string name;//Field (class içinde taanaımlanan normal değişken)


        public int Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }

        public string Mesaj()
        {
            string mesaj = "Benim adım " + name;
            return mesaj;
        }





       string id;
        public string Id { get {return id; } set 
            {
                if (value.ToString().Length==1)
                {
                    string newValue = "00" + value;
                    id = newValue;
                }
                else
                {
                id = value; 
                }
            } 
        }


        public int Mahmut { get { return 3; } }

    }
}
