
namespace ThreeSessionWindowsOOP
{
    partial class FrmOgrenci
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
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnIndirim = new System.Windows.Forms.Button();
            this.btnFiyatGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.Location = new System.Drawing.Point(12, 12);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(156, 64);
            this.btnOgrenci.TabIndex = 0;
            this.btnOgrenci.Text = "button1";
            this.btnOgrenci.UseVisualStyleBackColor = true;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(244, 23);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(75, 23);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "Obje Oluştur";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnIndirim
            // 
            this.btnIndirim.Location = new System.Drawing.Point(257, 115);
            this.btnIndirim.Name = "btnIndirim";
            this.btnIndirim.Size = new System.Drawing.Size(110, 30);
            this.btnIndirim.TabIndex = 2;
            this.btnIndirim.Text = "İndirim Yap";
            this.btnIndirim.UseVisualStyleBackColor = true;
            this.btnIndirim.Click += new System.EventHandler(this.btnIndirim_Click);
            // 
            // btnFiyatGoster
            // 
            this.btnFiyatGoster.Location = new System.Drawing.Point(244, 52);
            this.btnFiyatGoster.Name = "btnFiyatGoster";
            this.btnFiyatGoster.Size = new System.Drawing.Size(91, 39);
            this.btnFiyatGoster.TabIndex = 3;
            this.btnFiyatGoster.Text = "Fiyat Göster";
            this.btnFiyatGoster.UseVisualStyleBackColor = true;
            this.btnFiyatGoster.Click += new System.EventHandler(this.btnFiyatGoster_Click);
            // 
            // FrmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFiyatGoster);
            this.Controls.Add(this.btnIndirim);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnOgrenci);
            this.Name = "FrmOgrenci";
            this.Text = "FrmOgrenci";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnIndirim;
        private System.Windows.Forms.Button btnFiyatGoster;
    }
}