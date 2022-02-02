
namespace ThreeSessionWindowsOOP.Inheritance
{
    partial class FrmInheritance
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
            this.btnMirasAlma = new System.Windows.Forms.Button();
            this.cmbUrunler = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnMirasAlma
            // 
            this.btnMirasAlma.Location = new System.Drawing.Point(566, 12);
            this.btnMirasAlma.Name = "btnMirasAlma";
            this.btnMirasAlma.Size = new System.Drawing.Size(222, 74);
            this.btnMirasAlma.TabIndex = 0;
            this.btnMirasAlma.Text = "Miras Alma";
            this.btnMirasAlma.UseVisualStyleBackColor = true;
            this.btnMirasAlma.Click += new System.EventHandler(this.btnMirasAlma_Click);
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.Location = new System.Drawing.Point(12, 12);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(199, 21);
            this.cmbUrunler.TabIndex = 1;
            // 
            // FrmInheritance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbUrunler);
            this.Controls.Add(this.btnMirasAlma);
            this.Name = "FrmInheritance";
            this.Text = "FrmInheritance";
            this.Load += new System.EventHandler(this.FrmInheritance_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMirasAlma;
        private System.Windows.Forms.ComboBox cmbUrunler;
    }
}