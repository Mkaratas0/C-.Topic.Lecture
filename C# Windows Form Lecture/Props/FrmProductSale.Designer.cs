
namespace ThreeSessionWindowsOOP.Props
{
    partial class FrmProductSale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnComputer = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.prgCoupons = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddBalance = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnPhone = new System.Windows.Forms.Button();
            this.btnHeadphone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.lstUrunSepeti = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerName.Location = new System.Drawing.Point(577, 19);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(0, 25);
            this.lblCustomerName.TabIndex = 0;
            // 
            // btnComputer
            // 
            this.btnComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnComputer.Location = new System.Drawing.Point(10, 4);
            this.btnComputer.Name = "btnComputer";
            this.btnComputer.Size = new System.Drawing.Size(143, 47);
            this.btnComputer.TabIndex = 1;
            this.btnComputer.Text = "Bilgisayar-2500";
            this.btnComputer.UseVisualStyleBackColor = true;
            this.btnComputer.Click += new System.EventHandler(this.btnComputer_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBalance.Location = new System.Drawing.Point(499, 44);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(207, 25);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = "MÜŞTERİ BAKİYESİ";
            // 
            // prgCoupons
            // 
            this.prgCoupons.Location = new System.Drawing.Point(10, 163);
            this.prgCoupons.Name = "prgCoupons";
            this.prgCoupons.Size = new System.Drawing.Size(493, 23);
            this.prgCoupons.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "bakiye yetmiyorsa 5 kuponu varsa alabilir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "bakiye yetmiyorsa alamayacak ve bakiye yetersiz görecek ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(469, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "her 2 ürün alışında 1 kupon kazanacak 5 tane kuponu varsaalacağı sıradaki ürün be" +
    "dava olacak ,\r\n5 kuponu varken ürün alınca bedavaya almış olduktan sonra kuponla" +
    "rı sıfırlanacak";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(570, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ürün buttonlarına basınca bir emin misiniz sorusu gelecek daha sonra evet derse ü" +
    "rünü satın alacak ve bakiye azalacak ";
            // 
            // btnAddBalance
            // 
            this.btnAddBalance.Location = new System.Drawing.Point(611, 85);
            this.btnAddBalance.Name = "btnAddBalance";
            this.btnAddBalance.Size = new System.Drawing.Size(106, 37);
            this.btnAddBalance.TabIndex = 6;
            this.btnAddBalance.Text = "Bakiye+";
            this.btnAddBalance.UseVisualStyleBackColor = true;
            this.btnAddBalance.Click += new System.EventHandler(this.btnAddBalance_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(589, 154);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(117, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Text = "123";
            this.txtPassword.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(623, 180);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(83, 35);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "TAMAM";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(589, 128);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(117, 20);
            this.txtAmount.TabIndex = 7;
            this.txtAmount.Text = "1000";
            this.txtAmount.Visible = false;
            // 
            // btnPhone
            // 
            this.btnPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPhone.Location = new System.Drawing.Point(10, 57);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(143, 47);
            this.btnPhone.TabIndex = 1;
            this.btnPhone.Text = "Telefon-7000";
            this.btnPhone.UseVisualStyleBackColor = true;
            this.btnPhone.Click += new System.EventHandler(this.btnPhone_Click);
            // 
            // btnHeadphone
            // 
            this.btnHeadphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHeadphone.Location = new System.Drawing.Point(10, 110);
            this.btnHeadphone.Name = "btnHeadphone";
            this.btnHeadphone.Size = new System.Drawing.Size(143, 47);
            this.btnHeadphone.TabIndex = 1;
            this.btnHeadphone.Text = "Telefon-300";
            this.btnHeadphone.UseVisualStyleBackColor = true;
            this.btnHeadphone.Click += new System.EventHandler(this.btnHeadphone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "KULLANICI CLASSINA SEPET EKLENECEK(ARTIK NASIL YAPABİLİYOSAN)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(590, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "KULLANICI CLASSINDAN KUPON İLERLEMESİ GİDECEK 5000+ TL ÜRÜNLER 1 KUPON 10000+ ÜRÜ" +
    "NLER 2 KUPON";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ÜRÜNLERLE İLGİLİ YENİ CLASS";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(10, 348);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(71, 25);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "button1";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lstUrunSepeti
            // 
            this.lstUrunSepeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstUrunSepeti.FormattingEnabled = true;
            this.lstUrunSepeti.ItemHeight = 24;
            this.lstUrunSepeti.Location = new System.Drawing.Point(723, 44);
            this.lstUrunSepeti.Name = "lstUrunSepeti";
            this.lstUrunSepeti.Size = new System.Drawing.Size(255, 364);
            this.lstUrunSepeti.TabIndex = 10;
            // 
            // FrmProductSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 450);
            this.Controls.Add(this.lstUrunSepeti);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnAddBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prgCoupons);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btnHeadphone);
            this.Controls.Add(this.btnPhone);
            this.Controls.Add(this.btnComputer);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "FrmProductSale";
            this.Text = "FrmProductSale";
            this.Load += new System.EventHandler(this.FrmProductSale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnComputer;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.ProgressBar prgCoupons;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddBalance;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnPhone;
        private System.Windows.Forms.Button btnHeadphone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ListBox lstUrunSepeti;
    }
}