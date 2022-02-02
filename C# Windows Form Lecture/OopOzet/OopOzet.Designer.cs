
namespace ThreeSessionWindowsOOP.OopOzet
{
    partial class OopOzet
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
            this.btnKedi = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnKedi
            // 
            this.btnKedi.Location = new System.Drawing.Point(12, 12);
            this.btnKedi.Name = "btnKedi";
            this.btnKedi.Size = new System.Drawing.Size(180, 54);
            this.btnKedi.TabIndex = 0;
            this.btnKedi.Text = "Kedi";
            this.btnKedi.UseVisualStyleBackColor = true;
            this.btnKedi.Click += new System.EventHandler(this.btnKedi_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OopOzet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKedi);
            this.Name = "OopOzet";
            this.Text = "OopOzet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKedi;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}