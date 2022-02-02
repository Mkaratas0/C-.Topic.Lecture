using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeSessionWindowsOOP.StaticClasses
{
    public partial class FrmStatik : Form
    {
        public FrmStatik()
        {
            InitializeComponent();
        }

        private void btnStatic_Click(object sender, EventArgs e)
        {
            //StatikSinif.statikSayi = 25;
            //StatikSinif.StatikOzellik = 10;
            //MessageBox.Show(StatikSinif.StatikOzellik.ToString());
            //MessageBox.Show(StatikSinif.statikSayi.ToString());
        }

        private void btnStatik2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(StatikSinif.StatikToplam().ToString());
            //Math
            //Convert

            //FakeMath
            //Math.Min
            //Math.Max
            //Toplama
            //Çıkarma
            //Çarpma
            //Bölme
            //Karesini Alma
            //Pi 3.14
            MessageBox.Show(FakeMath.KareAl(3).ToString());
        }
    }
}
