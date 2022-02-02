
namespace ThreeSessionWindowsOOP.Props
{
    partial class FrmProps
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
            this.btnHizGoster = new System.Windows.Forms.Button();
            this.btnGazVer = new System.Windows.Forms.Button();
            this.btnFren = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHizGoster
            // 
            this.btnHizGoster.Location = new System.Drawing.Point(313, 12);
            this.btnHizGoster.Name = "btnHizGoster";
            this.btnHizGoster.Size = new System.Drawing.Size(138, 57);
            this.btnHizGoster.TabIndex = 0;
            this.btnHizGoster.Text = "button1";
            this.btnHizGoster.UseVisualStyleBackColor = true;
            this.btnHizGoster.Click += new System.EventHandler(this.btnHizGoster_Click);
            // 
            // btnGazVer
            // 
            this.btnGazVer.Location = new System.Drawing.Point(183, 98);
            this.btnGazVer.Name = "btnGazVer";
            this.btnGazVer.Size = new System.Drawing.Size(130, 75);
            this.btnGazVer.TabIndex = 1;
            this.btnGazVer.Text = "GazaBas";
            this.btnGazVer.UseVisualStyleBackColor = true;
            this.btnGazVer.Click += new System.EventHandler(this.btnGazVer_Click);
            // 
            // btnFren
            // 
            this.btnFren.Location = new System.Drawing.Point(475, 98);
            this.btnFren.Name = "btnFren";
            this.btnFren.Size = new System.Drawing.Size(130, 75);
            this.btnFren.TabIndex = 1;
            this.btnFren.Text = "Frenle";
            this.btnFren.UseVisualStyleBackColor = true;
            this.btnFren.Click += new System.EventHandler(this.btnFren_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmProps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFren);
            this.Controls.Add(this.btnGazVer);
            this.Controls.Add(this.btnHizGoster);
            this.Name = "FrmProps";
            this.Text = "FrmProps";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHizGoster;
        private System.Windows.Forms.Button btnGazVer;
        private System.Windows.Forms.Button btnFren;
        private System.Windows.Forms.Button button1;
    }
}