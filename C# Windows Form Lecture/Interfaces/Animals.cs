using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSessionWindowsOOP.Interfaces
{
    abstract class Animals
    {
        public abstract string AdapteOl();

        int seviye;
        public int Seviye
        {
            get { return seviye; }

            set
            {
                if (value > 2)
                {
                    seviye = 2;
                }
                else if (value < 0)
                {
                    seviye = 0;
                }
                else
                {
                    seviye = value;
                }
            }
        }

        public abstract List<string> Turler { get; }
    }

    interface IEvrim
    {
        string EvrimGecir(string yeniTur);

        int GelismisSeviye { get; set; }
    }


    class Dinozor : Animals
    {
        public override List<string> Turler => new List<string> { "Timsah", "Kertenkele", "Tavuk" };



        public override string AdapteOl()
        {
            Seviye++;
            return Turler[Seviye];
        }
    }

    class GriKurt : Animals, IEvrim
    {
        List<string> turler = new List<string> { "Alaska Kurdu", "Golden", "Pug" };

        public override List<string> Turler => turler;

        public int GelismisSeviye { get; set; }

        public override string AdapteOl()
        {
            Seviye++;
            return Turler[Seviye];
        }

        public string EvrimGecir(string yeniTur)
        {
            Turler.Add(yeniTur);
           
            GelismisSeviye = Turler.Count-1;
           
            return Turler[GelismisSeviye];
        }
    }
}
