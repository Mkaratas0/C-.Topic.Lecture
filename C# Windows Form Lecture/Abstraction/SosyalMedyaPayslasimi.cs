using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSessionWindowsOOP.Abstraction
{
    abstract class SosyalMedyaPayslasimi
    {
        public abstract string Kullanici { get; set; }
        public abstract DateTime PaylasimTarihi { get; set; }
        public abstract int EtkilesimSayisi { get; set; }
        public abstract void Paylas(string ag);
    }

    class InstagramPaylasimi : SosyalMedyaPayslasimi
    {

        public override string Kullanici { get; set; }
        public override DateTime PaylasimTarihi { get; set; }
        public override int EtkilesimSayisi { get; set; }
        public override void Paylas(string ag)
        {
            System.Windows.Forms.MessageBox.Show(ag + " da paylasildi.");
        }

        public bool isReels { get; set; }

    }
}
