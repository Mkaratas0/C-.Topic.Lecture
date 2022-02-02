
namespace ThreeSessionWindowsOOP.Interfaces
{
    partial class FrmCarRace
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
            this.btnSupra = new System.Windows.Forms.Button();
            this.btnAudi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSupra
            // 
            this.btnSupra.Location = new System.Drawing.Point(140, 50);
            this.btnSupra.Name = "btnSupra";
            this.btnSupra.Size = new System.Drawing.Size(172, 64);
            this.btnSupra.TabIndex = 0;
            this.btnSupra.Text = "Supra Hızı";
            this.btnSupra.UseVisualStyleBackColor = true;
            this.btnSupra.Click += new System.EventHandler(this.btnSupra_Click);
            // 
            // btnAudi
            // 
            this.btnAudi.Location = new System.Drawing.Point(480, 50);
            this.btnAudi.Name = "btnAudi";
            this.btnAudi.Size = new System.Drawing.Size(172, 64);
            this.btnAudi.TabIndex = 0;
            this.btnAudi.Text = "AudiHızı";
            this.btnAudi.UseVisualStyleBackColor = true;
            this.btnAudi.Click += new System.EventHandler(this.btnAudi_Click);
            // 
            // FrmCarRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 257);
            this.Controls.Add(this.btnAudi);
            this.Controls.Add(this.btnSupra);
            this.Name = "FrmCarRace";
            this.Text = "FrmCarRace";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSupra;
        private System.Windows.Forms.Button btnAudi;
    }
}