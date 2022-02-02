
namespace ThreeSessionWindowsOOP.ClassesExample1
{
    partial class ProductScreen
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.lstProductId = new System.Windows.Forms.ListBox();
            this.lstProductName = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDoviz = new System.Windows.Forms.ComboBox();
            this.btnDovizFiyat = new System.Windows.Forms.Button();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.lblToplam = new System.Windows.Forms.Label();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.btnUrunCikar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(56, 13);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            this.txtId.Text = "123";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(56, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Samsung J7";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(56, 65);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.Text = "2500";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(56, 91);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 20);
            this.txtType.TabIndex = 3;
            this.txtType.Text = "telefon";
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.Location = new System.Drawing.Point(56, 117);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(100, 29);
            this.btnCreateProduct.TabIndex = 4;
            this.btnCreateProduct.Text = "Oluştur";
            this.btnCreateProduct.UseVisualStyleBackColor = true;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // lstProductId
            // 
            this.lstProductId.FormattingEnabled = true;
            this.lstProductId.Location = new System.Drawing.Point(162, 12);
            this.lstProductId.Name = "lstProductId";
            this.lstProductId.Size = new System.Drawing.Size(73, 134);
            this.lstProductId.TabIndex = 5;
            this.lstProductId.SelectedIndexChanged += new System.EventHandler(this.lstProductId_SelectedIndexChanged);
            // 
            // lstProductName
            // 
            this.lstProductName.FormattingEnabled = true;
            this.lstProductName.Location = new System.Drawing.Point(241, 12);
            this.lstProductName.Name = "lstProductName";
            this.lstProductName.Size = new System.Drawing.Size(234, 134);
            this.lstProductName.TabIndex = 6;
            this.lstProductName.SelectedIndexChanged += new System.EventHandler(this.lstProductName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "İsim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tür";
            // 
            // cmbDoviz
            // 
            this.cmbDoviz.FormattingEnabled = true;
            this.cmbDoviz.Items.AddRange(new object[] {
            "Dolar",
            "Euro",
            "Sterlin",
            "Yen",
            "Ruble"});
            this.cmbDoviz.Location = new System.Drawing.Point(481, 12);
            this.cmbDoviz.Name = "cmbDoviz";
            this.cmbDoviz.Size = new System.Drawing.Size(121, 21);
            this.cmbDoviz.TabIndex = 8;
            // 
            // btnDovizFiyat
            // 
            this.btnDovizFiyat.Location = new System.Drawing.Point(481, 39);
            this.btnDovizFiyat.Name = "btnDovizFiyat";
            this.btnDovizFiyat.Size = new System.Drawing.Size(75, 23);
            this.btnDovizFiyat.TabIndex = 9;
            this.btnDovizFiyat.Text = "Döviz Göster";
            this.btnDovizFiyat.UseVisualStyleBackColor = true;
            this.btnDovizFiyat.Click += new System.EventHandler(this.btnDovizFiyat_Click);
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.Location = new System.Drawing.Point(12, 291);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(145, 147);
            this.lstSepet.TabIndex = 10;
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(163, 291);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(13, 13);
            this.lblToplam.TabIndex = 11;
            this.lblToplam.Text = "0";
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(162, 152);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(104, 33);
            this.btnSepeteEkle.TabIndex = 12;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // btnUrunCikar
            // 
            this.btnUrunCikar.Location = new System.Drawing.Point(166, 320);
            this.btnUrunCikar.Name = "btnUrunCikar";
            this.btnUrunCikar.Size = new System.Drawing.Size(80, 39);
            this.btnUrunCikar.TabIndex = 13;
            this.btnUrunCikar.Text = "button1";
            this.btnUrunCikar.UseVisualStyleBackColor = true;
            this.btnUrunCikar.Click += new System.EventHandler(this.btnUrunCikar_Click);
            // 
            // ProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUrunCikar);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.btnDovizFiyat);
            this.Controls.Add(this.cmbDoviz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstProductName);
            this.Controls.Add(this.lstProductId);
            this.Controls.Add(this.btnCreateProduct);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Name = "ProductScreen";
            this.Text = "ProductScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Button btnCreateProduct;
        private System.Windows.Forms.ListBox lstProductId;
        private System.Windows.Forms.ListBox lstProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDoviz;
        private System.Windows.Forms.Button btnDovizFiyat;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.Button btnUrunCikar;
    }
}