using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreeSessionWindowsOOP.GeneralExample1_13_01_22;

namespace ThreeSessionWindowsOOP.OopOzet
{
    public partial class OopOzet : Form
    {
        public OopOzet()
        {
            InitializeComponent();
        }

        private void btnKedi_Click(object sender, EventArgs e)
        {
            Kedi kedi = new Kedi();//Classtan obje çağırmak instance almaktır

            kedi.isim = "Ponçik";
            kedi.sahibi = "Hasan";
            kedi.yas = 2;
            kedi.renk = Color.Turquoise;

            Kopek doge = new Kopek();

            MessageBox.Show(kedi.Ses());
            MessageBox.Show(doge.Ses());

            List<EvHayvanlari> evimdekiHayvanlar = new List<EvHayvanlari>();

            EvHayvanlari yeniKedi = new Kedi();

            MirasYediClass b = new MirasYediClass();
            MirasYemediClass a = new MirasYemediClass();

            a.Calistir();
            b.Calistir();
        }
    }
}
