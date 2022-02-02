using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeSessionWindowsOOP.Props
{
    public partial class FrmProps : Form
    {
        public FrmProps()
        {
            InitializeComponent();
        }

        Car araba = new Car(100);

        private void btnHizGoster_Click(object sender, EventArgs e)
        {
            MessageBox.Show(araba.AnlikHiz.ToString());
        }

        private void btnGazVer_Click(object sender, EventArgs e)
        {
            araba.GazaBas();
            MessageBox.Show("Araba hızlandı " + araba.AnlikHiz.ToString());
        }

        private void btnFren_Click(object sender, EventArgs e)
        {

            araba.Frenle();
            MessageBox.Show("Araba Yavaşladı " + araba.AnlikHiz.ToString());
        }
    }
}
