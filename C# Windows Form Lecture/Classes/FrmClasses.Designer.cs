
namespace ThreeSessionWindowsOOP.Classes
{
    partial class FrmClasses
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
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.nmrGrade = new System.Windows.Forms.NumericUpDown();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.btnDoesHave = new System.Windows.Forms.Button();
            this.btnTimeLeft = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.Location = new System.Drawing.Point(12, 12);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(98, 38);
            this.btnCreateStudent.TabIndex = 0;
            this.btnCreateStudent.Text = "ÖğrenciEkle";
            this.btnCreateStudent.UseVisualStyleBackColor = true;
            this.btnCreateStudent.Click += new System.EventHandler(this.btnCreateStudent_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Hasan";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(12, 108);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 1;
            this.txtSurname.Text = "Karakoç";
            // 
            // nmrGrade
            // 
            this.nmrGrade.Location = new System.Drawing.Point(12, 134);
            this.nmrGrade.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmrGrade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrGrade.Name = "nmrGrade";
            this.nmrGrade.Size = new System.Drawing.Size(98, 20);
            this.nmrGrade.TabIndex = 2;
            this.nmrGrade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(12, 56);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 1;
            this.txtNum.Text = "2323";
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.Location = new System.Drawing.Point(12, 167);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(212, 264);
            this.lstStudents.TabIndex = 3;
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(149, 12);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(91, 38);
            this.btnSearchStudent.TabIndex = 4;
            this.btnSearchStudent.Text = "button1";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(230, 167);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(130, 38);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Kitap Ekle";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // cmbBooks
            // 
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Items.AddRange(new object[] {
            "Suç ve Ceza",
            "Güliverin Gezileri",
            "Siyah Kan",
            "Kinyas ve Kayra",
            "Araba Sevdası "});
            this.cmbBooks.Location = new System.Drawing.Point(230, 211);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(121, 21);
            this.cmbBooks.TabIndex = 6;
            // 
            // btnDoesHave
            // 
            this.btnDoesHave.Location = new System.Drawing.Point(230, 252);
            this.btnDoesHave.Name = "btnDoesHave";
            this.btnDoesHave.Size = new System.Drawing.Size(75, 23);
            this.btnDoesHave.TabIndex = 7;
            this.btnDoesHave.Text = "Kitap var mı";
            this.btnDoesHave.UseVisualStyleBackColor = true;
            this.btnDoesHave.Click += new System.EventHandler(this.btnDoesHave_Click);
            // 
            // btnTimeLeft
            // 
            this.btnTimeLeft.Location = new System.Drawing.Point(230, 281);
            this.btnTimeLeft.Name = "btnTimeLeft";
            this.btnTimeLeft.Size = new System.Drawing.Size(75, 23);
            this.btnTimeLeft.TabIndex = 7;
            this.btnTimeLeft.Text = "Kalan Süre";
            this.btnTimeLeft.UseVisualStyleBackColor = true;
            this.btnTimeLeft.Click += new System.EventHandler(this.btnTimeLeft_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(230, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Kitabının adı";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(230, 339);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Aldığı tarih";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(230, 368);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Bitiş tarihi";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Students classında bu istedğim verileri dönen metodlar ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(635, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kalan süreyi hesaplayan metod";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(659, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Constructor metod (yapıcı)";
            // 
            // FrmClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnTimeLeft);
            this.Controls.Add(this.btnDoesHave);
            this.Controls.Add(this.cmbBooks);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnSearchStudent);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.nmrGrade);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnCreateStudent);
            this.Name = "FrmClasses";
            this.Text = "FrmClasses";
            this.Load += new System.EventHandler(this.FrmClasses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateStudent;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.NumericUpDown nmrGrade;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.Button btnDoesHave;
        private System.Windows.Forms.Button btnTimeLeft;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}