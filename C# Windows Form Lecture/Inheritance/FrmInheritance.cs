using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeSessionWindowsOOP.Inheritance
{
    public partial class FrmInheritance : Form
    {
        public FrmInheritance()
        {
            InitializeComponent();
        }

        private void FrmInheritance_Load(object sender, EventArgs e)
        {
            List<Urunler> urunler = new List<Urunler>();

            Urunler telefon1 = new Telefon(123,123123,4,20000,5,"V");
            Urunler bilgisayar1 = new MasaustuPc(124,1231,5,false,1000,"MACOS X");

            cmbUrunler.DisplayMember="Ozet";
           
            urunler.Add(telefon1);
            urunler.Add(bilgisayar1);
          
            cmbUrunler.Items.AddRange(urunler.ToArray());

            foreach (Urunler item in cmbUrunler.Items)
            {
                MessageBox.Show(item.degerlendirmePuani.ToString());
            }
        }

        private void btnMirasAlma_Click(object sender, EventArgs e)
        {
            Urunler urun = new Urunler();
            Telefon tel = new Telefon(1,1000d,2,3,2000,"C");
            MasaustuPc pc = new MasaustuPc(3,1000,4,true,500,"Windows 10");

            Telefon telefon = new Telefon
            {
                id = 100,
                degerlendirmePuani = 5,
                fiyat = 2000,
                batarya = 5000,
                onKamera = 20,
                sarjGirisi = "A"
            };



            MessageBox.Show(tel.fiyat.ToString()) ;
            MessageBox.Show(pc.fiyat.ToString()) ;

        }

    }
}
