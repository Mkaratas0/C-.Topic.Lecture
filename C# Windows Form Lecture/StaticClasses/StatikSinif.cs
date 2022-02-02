using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSessionWindowsOOP.StaticClasses
{
    static class StatikSinif
    {
        public static int statikSayi;

        public static int StatikOzellik { get; set; }

        public static int StatikToplam()
        {
            return statikSayi + StatikOzellik;
        }
    }
}
