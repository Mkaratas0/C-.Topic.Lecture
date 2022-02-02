using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeSessionWindowsOOP.Interfaces
{
    public partial class FrmCarRace : Form
    {
        public FrmCarRace()
        {
            InitializeComponent();
            List<int> a = new List<int>();
        }

        Audi audi = new Audi { motorSayisi = 3, aracHizi = 100, ledAugment = true };
        Supra supra = new Supra { motorSayisi = 5, aracHizi = 100, customColors = "Red Blue Purple" };
        private void btnSupra_Click(object sender, EventArgs e)
        {
            supra.GazaBas();
            MessageBox.Show(supra.aracHizi.ToString());
        }

        private void btnAudi_Click(object sender, EventArgs e)
        {
            audi.Nitro();
            audi.GazaBas();
            MessageBox.Show(audi.aracHizi.ToString());
        }
    }
}
