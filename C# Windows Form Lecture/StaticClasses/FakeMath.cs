using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSessionWindowsOOP.StaticClasses
{
    static class FakeMath
    {
        public static double PI { get { return 3.14d; } }

        public static int Toplam(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static int Fark(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

        public static float Bolum(float sayi1, float sayi2)
        {
            return sayi1 / sayi2;
        }

        public static int Carpim(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }



        public static int Minimum(int sayi1, int sayi2)
        {
            if (sayi2>sayi1)
            {
                return sayi1;
            }
            else
            {
                return sayi2;
            }
        }
        public static int Maksimum(int sayi1, int sayi2)
        {
            if (sayi2 > sayi1)
            {
                return sayi2;
            }
            else
            {
                return sayi1;
            }
        }

        public static int KareAl(int sayi)
        {
            return sayi * sayi;
        }
    }
}
