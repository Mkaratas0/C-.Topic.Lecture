using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSessionWindowsOOP.Interfaces
{
    abstract class Car
    {
        public int motorSayisi;//arac silindileri vs vs
        public int aracHizi;

        public abstract void GazaBas();
    }

    interface IModifiye
    {
        void Nitro();
        int EkstraSilindir { get; }
    }


    class Supra : Car
    {
        public string customColors;

        public override void GazaBas()
        {
            aracHizi += 200;
        }
    }
    class Audi : Car, IModifiye
    {
        public bool ledAugment;

        public int EkstraSilindir { get => 2; }


        public override void GazaBas()
        {
            aracHizi += 50;
        }

        public void Nitro()
        {
            aracHizi += 200 * EkstraSilindir;
        }
    }

}
