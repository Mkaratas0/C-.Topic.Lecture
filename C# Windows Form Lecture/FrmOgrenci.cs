using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeSessionWindowsOOP
{
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.ad = "Tevfik";
            ogrenci.sinif = 2;
            ogrenci.yas = 25;
            ogrenci.dogumTarihi = DateTime.Now;

            MessageBox.Show(ogrenci.ad);
        }
        //Instance alma
        Products telefon = new Products();
        private void btnProduct_Click(object sender, EventArgs e)
        {
            telefon.price = 1500d;
            telefon.name = "Xiaomi telefon";
            telefon.model = "Xiaomi Note9";
            telefon.productionDate = DateTime.Now;
            telefon.color = "Siyah";
            telefon.category = "Teknoloji";
        }

        private void btnIndirim_Click(object sender, EventArgs e)
        {
            telefon.Discount(25);
        }

        private void btnFiyatGoster_Click(object sender, EventArgs e)
        {
            MessageBox.Show(telefon.price.ToString());
        }
    }
}
