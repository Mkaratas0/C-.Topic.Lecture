
namespace ThreeSessionWindowsOOP.StaticClasses
{
    partial class FrmStatik
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
            this.btnStatic = new System.Windows.Forms.Button();
            this.btnStatik2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStatic
            // 
            this.btnStatic.Location = new System.Drawing.Point(12, 12);
            this.btnStatic.Name = "btnStatic";
            this.btnStatic.Size = new System.Drawing.Size(162, 66);
            this.btnStatic.TabIndex = 0;
            this.btnStatic.Text = "Statik Sınıf";
            this.btnStatic.UseVisualStyleBackColor = true;
            this.btnStatic.Click += new System.EventHandler(this.btnStatic_Click);
            // 
            // btnStatik2
            // 
            this.btnStatik2.Location = new System.Drawing.Point(180, 12);
            this.btnStatik2.Name = "btnStatik2";
            this.btnStatik2.Size = new System.Drawing.Size(162, 66);
            this.btnStatik2.TabIndex = 1;
            this.btnStatik2.Text = "button1";
            this.btnStatik2.UseVisualStyleBackColor = true;
            this.btnStatik2.Click += new System.EventHandler(this.btnStatik2_Click);
            // 
            // FrmStatik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStatik2);
            this.Controls.Add(this.btnStatic);
            this.Name = "FrmStatik";
            this.Text = "FrmStatik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStatic;
        private System.Windows.Forms.Button btnStatik2;
    }
}