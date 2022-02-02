
namespace ThreeSessionWindowsOOP.Interfaces
{
    partial class FrmEvrim
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
            this.btnEvrim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEvrim
            // 
            this.btnEvrim.Location = new System.Drawing.Point(12, 12);
            this.btnEvrim.Name = "btnEvrim";
            this.btnEvrim.Size = new System.Drawing.Size(185, 72);
            this.btnEvrim.TabIndex = 0;
            this.btnEvrim.Text = "Evrim";
            this.btnEvrim.UseVisualStyleBackColor = true;
            this.btnEvrim.Click += new System.EventHandler(this.btnEvrim_Click);
            // 
            // FrmEvrim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEvrim);
            this.Name = "FrmEvrim";
            this.Text = "FrmEvrim";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEvrim;
    }
}