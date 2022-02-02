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
    public partial class FrmProductSale : Form
    {
        public FrmProductSale()
        {
            InitializeComponent();
        }
        Customer customer = new Customer();
        private void FrmProductSale_Load(object sender, EventArgs e)
        {
            lstUrunSepeti.DisplayMember = "Display";


            customer.Coupons = 0;
            customer.NameSurname = "Hasan Karakoç";
            customer.Balance = 3000;

            lblCustomerName.Text = customer.NameSurname;
            lblBalance.Text = customer.Balance.ToString();
        }

        private void btnComputer_Click(object sender, EventArgs e)
        {

            CusProduct computer = new CusProduct(); 
            computer.Id = 1;
            computer.Name = "HP Bilgisayar";
            computer.Price = 5000;
         
            DialogResult accept = MessageBox.Show("Ürünü almak istediğinizden emin misiniz?", "İşlem Onayı", MessageBoxButtons.YesNo);
            if (accept == DialogResult.Yes)
            {
                if (customer.Coupons == 5)
                {
                    MessageBox.Show("Ürün satın alındı(Kupon kullanıldı): " + computer.Name);
                    customer.Coupons = 0;
                    customer.Basket.Add(computer);
                }
                else if (customer.Balance >= computer.Price)
                {
                    customer.Balance -= computer.Price;
                    MessageBox.Show("Ürün satın alındı: " + computer.Name);
                    customer.Coupons += computer.CouponValue;
                    customer.Basket.Add(computer);
                }
                else
                {
                    MessageBox.Show("Geçersiz Bakiye");
                }
            }

            lstUrunSepeti.Items.Clear();
            foreach (var urun in customer.Basket)
            {
                lstUrunSepeti.Items.Add(urun);
            }
            lblBalance.Text = customer.Balance.ToString();
            prgCoupons.Value = customer.Coupons * 20;
        }

        private void btnAddBalance_Click(object sender, EventArgs e)
        {
            if (btnAddBalance.Text=="Bakiye+")
            {
                txtAmount.Visible = true;
                txtPassword.Visible = true;
                btnConfirm.Visible = true;
                btnAddBalance.Text = "Kapat [x]";
            }
            else
            {
                txtAmount.Visible = false;
                txtPassword.Visible = false;
                btnConfirm.Visible = false;
                btnAddBalance.Text = "Bakiye+";
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text != "" && txtAmount.Text != "")
                {
                    if (txtPassword.Text == customer.Password)
                    {
                        customer.Balance += Convert.ToDouble(txtAmount.Text);
                        lblBalance.Text = customer.Balance.ToString();

                        txtAmount.Text = "";
                        txtPassword.Text = "";

                        txtAmount.Visible = false;
                        txtPassword.Visible = false;
                        btnConfirm.Visible = false;
                        btnAddBalance.Text = "Bakiye+";

                    }
                    else
                    {
                        MessageBox.Show("Şifre Hatalı!");
                        txtPassword.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Boş alan bıraktınız.");
                }
            }
            catch (Exception)
            {
                txtAmount.Text = "";
                txtPassword.Text = "";
                MessageBox.Show("Hata!");
            }
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            double productPrice = Convert.ToDouble(btnPhone.Text.Split('-')[1]);
            DialogResult accept = MessageBox.Show("Ürünü almak istediğinizden emin misiniz?", "İşlem Onayı", MessageBoxButtons.YesNo);
            if (accept == DialogResult.Yes)
            {
                if (customer.Coupons < 5)
                {
                    if (customer.Balance >= productPrice)
                    {
                        if (customer.CouponProgress < 1)
                        {
                            customer.Balance -= productPrice;
                            customer.CouponProgress++;
                        }
                        else if (customer.CouponProgress >= 1)
                        {
                            customer.Balance -= productPrice;
                            customer.Coupons++;
                            customer.CouponProgress = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Yetersiz bakiye");
                    }
                }
                else if (customer.Coupons == 5)
                {
                    customer.Coupons = 0;
                    customer.CouponProgress = 0;
                    MessageBox.Show("Kuponla alışveriş yapıldı");
                }
            }

            lblBalance.Text = customer.Balance.ToString();
            prgCoupons.Value = customer.Coupons * 20;
        }

        private void btnHeadphone_Click(object sender, EventArgs e)
        {
            double productPrice = Convert.ToDouble(btnHeadphone.Text.Split('-')[1]);
            DialogResult accept = MessageBox.Show("Ürünü almak istediğinizden emin misiniz?", "İşlem Onayı", MessageBoxButtons.YesNo);
            if (accept == DialogResult.Yes)
            {
                if (customer.Coupons < 5)
                {
                    if (customer.Balance >= productPrice)
                    {
                        if (customer.CouponProgress < 1)
                        {
                            customer.Balance -= productPrice;
                            customer.CouponProgress++;
                        }
                        else if (customer.CouponProgress >= 1)
                        {
                            customer.Balance -= productPrice;
                            customer.Coupons++;
                            customer.CouponProgress = 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Yetersiz bakiye");
                    }
                }
                else if (customer.Coupons == 5)
                {
                    customer.Coupons = 0;
                    customer.CouponProgress = 0;
                    MessageBox.Show("Kuponla alışveriş yapıldı");
                }
            }

            lblBalance.Text = customer.Balance.ToString();
            prgCoupons.Value = customer.Coupons * 20;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            CusProduct a = new CusProduct();
            a.Name = "PC";
            customer.Basket.Add(a);


            MessageBox.Show(customer.Basket[0].Name);
        }
    }
}
