using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeSessionWindowsOOP.ClassesExample1
{
    public partial class ProductScreen : Form
    {
        public ProductScreen()
        {
            InitializeComponent();
        }
        List<Product> allProducts = new List<Product>();
        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Product pr = new Product(Convert.ToInt32(txtId.Text), txtName.Text, Convert.ToDouble(txtPrice.Text), txtType.Text);
                allProducts.Add(pr);
                lstProductId.Items.Add(pr.id);
                lstProductName.Items.Add(pr.name);
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
            }
        }

        private void lstProductId_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstProductName.SelectedIndex = lstProductId.SelectedIndex;
        }

        private void lstProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstProductId.SelectedIndex = lstProductName.SelectedIndex;
        }

        private void btnDovizFiyat_Click(object sender, EventArgs e)
        {
            string dovizBirimi = cmbDoviz.SelectedItem.ToString();
            MessageBox.Show(dovizBirimi + " Olarak: " + allProducts[lstProductId.SelectedIndex].DovizFiyat(dovizBirimi).ToString());
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            lstSepet.Items.Add(allProducts[lstProductId.SelectedIndex].id);

            double mevcutFiyat = Convert.ToDouble(lblToplam.Text);
            mevcutFiyat += allProducts[lstProductId.SelectedIndex].price;
            lblToplam.Text = mevcutFiyat.ToString();
        }

        private void btnUrunCikar_Click(object sender, EventArgs e)
        {
            foreach (Product product in allProducts)
            {
                if (product.id == Convert.ToInt32(lstSepet.SelectedItem))
                {
                    double mevcutFiyat = Convert.ToDouble(lblToplam.Text);
                    mevcutFiyat -= product.price;
                    lblToplam.Text = mevcutFiyat.ToString();
                    lstSepet.Items.Remove(lstSepet.SelectedItem);
                    break;
                }
            }
        }
    }
}
