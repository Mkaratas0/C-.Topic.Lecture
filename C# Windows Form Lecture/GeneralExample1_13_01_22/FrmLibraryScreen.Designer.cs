
namespace ThreeSessionWindowsOOP.GeneralExample1_13_01_22
{
    partial class FrmLibraryScreen
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
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.BtnBookDetails = new System.Windows.Forms.Button();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtBookPages = new System.Windows.Forms.TextBox();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.dtpPublishDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.btnCancelInput = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.btnPickBook = new System.Windows.Forms.Button();
            this.btnSeeBooks = new System.Windows.Forms.Button();
            this.btnLeaveBook = new System.Windows.Forms.Button();
            this.cmbTakenBooks = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.Location = new System.Drawing.Point(12, 12);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(306, 173);
            this.lstBooks.TabIndex = 0;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(324, 12);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(84, 37);
            this.btnAddBook.TabIndex = 1;
            this.btnAddBook.Text = "Ekle";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(324, 55);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(84, 37);
            this.btnDeleteBook.TabIndex = 1;
            this.btnDeleteBook.Text = "Sil";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Location = new System.Drawing.Point(324, 98);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(84, 37);
            this.btnEditBook.TabIndex = 1;
            this.btnEditBook.Text = "Düzenle";
            this.btnEditBook.UseVisualStyleBackColor = true;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // BtnBookDetails
            // 
            this.BtnBookDetails.Location = new System.Drawing.Point(324, 141);
            this.BtnBookDetails.Name = "BtnBookDetails";
            this.BtnBookDetails.Size = new System.Drawing.Size(84, 37);
            this.BtnBookDetails.TabIndex = 1;
            this.BtnBookDetails.Text = "Detayları Göster";
            this.BtnBookDetails.UseVisualStyleBackColor = true;
            this.BtnBookDetails.Click += new System.EventHandler(this.BtnBookDetails_Click);
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBookName.Location = new System.Drawing.Point(155, 52);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(167, 29);
            this.txtBookName.TabIndex = 2;
            this.txtBookName.Text = "a";
            // 
            // txtBookPages
            // 
            this.txtBookPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBookPages.Location = new System.Drawing.Point(155, 122);
            this.txtBookPages.Name = "txtBookPages";
            this.txtBookPages.Size = new System.Drawing.Size(42, 29);
            this.txtBookPages.TabIndex = 2;
            this.txtBookPages.Text = "1";
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBookAuthor.Location = new System.Drawing.Point(155, 87);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(167, 29);
            this.txtBookAuthor.TabIndex = 2;
            this.txtBookAuthor.Text = "a";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAmount.Location = new System.Drawing.Point(155, 157);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(42, 29);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.Text = "1";
            // 
            // dtpPublishDate
            // 
            this.dtpPublishDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpPublishDate.Location = new System.Drawing.Point(155, 192);
            this.dtpPublishDate.Name = "dtpPublishDate";
            this.dtpPublishDate.Size = new System.Drawing.Size(200, 29);
            this.dtpPublishDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kitap Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yazar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sayfa Sayısı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mevcut Adet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Basım Tarihi";
            // 
            // txtBookId
            // 
            this.txtBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBookId.Location = new System.Drawing.Point(155, 17);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(42, 29);
            this.txtBookId.TabIndex = 2;
            this.txtBookId.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Kitap Kayıt No:";
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.btnCancelInput);
            this.pnlInput.Controls.Add(this.label6);
            this.pnlInput.Controls.Add(this.label5);
            this.pnlInput.Controls.Add(this.txtBookName);
            this.pnlInput.Controls.Add(this.label4);
            this.pnlInput.Controls.Add(this.txtBookAuthor);
            this.pnlInput.Controls.Add(this.label3);
            this.pnlInput.Controls.Add(this.txtBookPages);
            this.pnlInput.Controls.Add(this.label2);
            this.pnlInput.Controls.Add(this.txtBookId);
            this.pnlInput.Controls.Add(this.txtAmount);
            this.pnlInput.Controls.Add(this.label1);
            this.pnlInput.Controls.Add(this.dtpPublishDate);
            this.pnlInput.Location = new System.Drawing.Point(12, 207);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(455, 257);
            this.pnlInput.TabIndex = 5;
            this.pnlInput.Visible = false;
            // 
            // btnCancelInput
            // 
            this.btnCancelInput.Location = new System.Drawing.Point(16, 228);
            this.btnCancelInput.Name = "btnCancelInput";
            this.btnCancelInput.Size = new System.Drawing.Size(416, 29);
            this.btnCancelInput.TabIndex = 7;
            this.btnCancelInput.Text = "İptal";
            this.btnCancelInput.UseVisualStyleBackColor = true;
            this.btnCancelInput.Click += new System.EventHandler(this.btnCancelInput_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(522, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 78);
            this.label7.TabIndex = 6;
            this.label7.Text = "Öğrenci classı oluştur\r\nöğrencilerin adı soyadı numarası ve sınıfı \r\nmevcut kitap" +
    "ları \r\nteslim alma tarihleri \r\nteslim etme tarihleri \r\nen fazla 2 kitap alabilir" +
    " \r\n";
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.Location = new System.Drawing.Point(522, 35);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(274, 264);
            this.lstStudents.TabIndex = 7;
            this.lstStudents.SelectedIndexChanged += new System.EventHandler(this.lstStudents_SelectedIndexChanged);
            // 
            // cmbBooks
            // 
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(805, 35);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(121, 21);
            this.cmbBooks.TabIndex = 8;
            // 
            // btnPickBook
            // 
            this.btnPickBook.Location = new System.Drawing.Point(805, 66);
            this.btnPickBook.Name = "btnPickBook";
            this.btnPickBook.Size = new System.Drawing.Size(124, 46);
            this.btnPickBook.TabIndex = 9;
            this.btnPickBook.Text = "Kitap Ekle";
            this.btnPickBook.UseVisualStyleBackColor = true;
            this.btnPickBook.Click += new System.EventHandler(this.btnPickBook_Click);
            // 
            // btnSeeBooks
            // 
            this.btnSeeBooks.Location = new System.Drawing.Point(802, 118);
            this.btnSeeBooks.Name = "btnSeeBooks";
            this.btnSeeBooks.Size = new System.Drawing.Size(124, 46);
            this.btnSeeBooks.TabIndex = 9;
            this.btnSeeBooks.Text = "Kitaplarını Gör";
            this.btnSeeBooks.UseVisualStyleBackColor = true;
            this.btnSeeBooks.Click += new System.EventHandler(this.btnSeeBooks_Click);
            // 
            // btnLeaveBook
            // 
            this.btnLeaveBook.Location = new System.Drawing.Point(802, 170);
            this.btnLeaveBook.Name = "btnLeaveBook";
            this.btnLeaveBook.Size = new System.Drawing.Size(124, 46);
            this.btnLeaveBook.TabIndex = 9;
            this.btnLeaveBook.Text = "Kitap Kaldır";
            this.btnLeaveBook.UseVisualStyleBackColor = true;
            this.btnLeaveBook.Click += new System.EventHandler(this.btnLeaveBook_Click);
            // 
            // cmbTakenBooks
            // 
            this.cmbTakenBooks.FormattingEnabled = true;
            this.cmbTakenBooks.Location = new System.Drawing.Point(802, 218);
            this.cmbTakenBooks.Name = "cmbTakenBooks";
            this.cmbTakenBooks.Size = new System.Drawing.Size(116, 21);
            this.cmbTakenBooks.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmLibraryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 483);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbTakenBooks);
            this.Controls.Add(this.btnLeaveBook);
            this.Controls.Add(this.btnSeeBooks);
            this.Controls.Add(this.btnPickBook);
            this.Controls.Add(this.cmbBooks);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.BtnBookDetails);
            this.Controls.Add(this.btnEditBook);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.lstBooks);
            this.Name = "FrmLibraryScreen";
            this.Text = "FrmLibraryScreen";
            this.Load += new System.EventHandler(this.FrmLibraryScreen_Load);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button BtnBookDetails;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtBookPages;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker dtpPublishDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancelInput;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.Button btnPickBook;
        private System.Windows.Forms.Button btnSeeBooks;
        private System.Windows.Forms.Button btnLeaveBook;
        private System.Windows.Forms.ComboBox cmbTakenBooks;
        private System.Windows.Forms.Button button1;
    }
}