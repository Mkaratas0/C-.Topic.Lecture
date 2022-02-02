using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeSessionWindowsOOP.GeneralExample1_13_01_22
{
    public partial class FrmLibraryScreen : Form
    {
        public FrmLibraryScreen()
        {
            InitializeComponent();
        }
        private void FrmLibraryScreen_Load(object sender, EventArgs e)
        {
            //lstBooks.SelectionMode = SelectionMode.MultiSimple;
            lstBooks.DisplayMember = "Display";
            cmbBooks.DisplayMember = "Display";
            cmbTakenBooks.DisplayMember = "Display";
            lstStudents.DisplayMember = "NameSurname";

            Student student = new Student();
            student.StudentNo = 1;
            student.NameSurname = "Faruk Aslan";
            student.StudentClass = 3;
            lstStudents.Items.Add(student);
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (btnAddBook.Text == "Ekle")
            {
                lstBooks.Enabled = false;
                btnDeleteBook.Enabled = false;
                btnEditBook.Enabled = false;
                BtnBookDetails.Enabled = false;
                pnlInput.Visible = true;
                btnAddBook.Text = "Tamam";
            }
            else
            {
                try
                {
                    Book addingBook = new Book();

                    addingBook.Id = Convert.ToInt32(txtBookId.Text);
                    addingBook.Name = txtBookName.Text;
                    addingBook.Author = txtBookAuthor.Text;
                    addingBook.Pages = Convert.ToInt32(txtBookPages.Text);
                    addingBook.Stock = Convert.ToInt32(txtAmount.Text);
                    addingBook.PublisDate = dtpPublishDate.Value;

                    bool doesContain = false;
                    foreach (Book kitaplar in lstBooks.Items)
                    {
                        if (kitaplar.Id == addingBook.Id)
                        {
                            doesContain = true;
                        }
                    }

                    if (doesContain)
                    {
                        MessageBox.Show("Bu id mevcut");
                        txtBookId.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("İşlem başarılı");
                        lstBooks.Items.Add(addingBook);//burada ekleniyor
                        ResetCombo();
                        txtBookId.Text = "";
                        txtBookName.Text = "";
                        txtBookAuthor.Text = "";
                        txtBookPages.Text = "";
                        txtAmount.Text = "";
                        dtpPublishDate.Value = DateTime.Now;

                        lstBooks.Enabled = true;
                        btnDeleteBook.Enabled = true;
                        btnEditBook.Enabled = true;
                        BtnBookDetails.Enabled = true;
                        pnlInput.Visible = false;
                        btnAddBook.Text = "Ekle";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata");
                }
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedIndex != -1)
            {
                DialogResult deleteConfirm = MessageBox.Show("Bu kitabı kaldırmak istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

                if (deleteConfirm == DialogResult.Yes)
                {
                    lstBooks.Items.Remove(lstBooks.SelectedItem);
                    MessageBox.Show("Silme başarılı.");
                    ResetCombo();
                }
                else
                {
                    lstBooks.SelectedIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("Silinecek kitabı seçiniz.");
            }
        }

        private void BtnBookDetails_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedIndex != -1)
            {
                Book book = new Book();
                book = lstBooks.SelectedItem as Book;//listedeki object türündeki nesneyi bir Book olarak kabul et.

                MessageBox.Show("Id:" + book.Id + "\n" + "Adı:" + book.Name + "\n" + "Yazar:" + book.Author + "\n" + "Sayfa Sayısı:" + book.Pages + "\n" + "Mecvut Adet:" + book.Stock + "\n" + "Yayınlanma Tarihi:" + book.PublisDate.ToShortDateString() + "\n", "Kitap Bilgileri:");
            }
            else
            {
                MessageBox.Show("Kitap seçiniz");
            }
        }

        private void btnCancelInput_Click(object sender, EventArgs e)
        {
            txtBookId.Text = "";
            txtBookName.Text = "";
            txtBookAuthor.Text = "";
            txtBookPages.Text = "";
            txtAmount.Text = "";
            dtpPublishDate.Value = DateTime.Now;
            pnlInput.Visible = false;
            lstBooks.Enabled = true;
            btnDeleteBook.Enabled = true;
            btnEditBook.Enabled = true;
            BtnBookDetails.Enabled = true;
            btnAddBook.Text = "Ekle";
            btnEditBook.Text = "Düzenle";
        }


        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedIndex != -1)
            {
                int changingIndex = lstBooks.SelectedIndex;

                if (btnEditBook.Text == "Düzenle")
                {
                    lstBooks.Enabled = false;
                    btnDeleteBook.Enabled = false;
                    btnAddBook.Enabled = false;
                    BtnBookDetails.Enabled = false;
                    btnEditBook.Text = "Tamam";
                    pnlInput.Visible = true;

                    Book editingBook = lstBooks.SelectedItem as Book;
                    txtBookId.Text = editingBook.Id.ToString();
                    txtBookName.Text = editingBook.Name;
                    txtBookAuthor.Text = editingBook.Author;
                    txtBookPages.Text = editingBook.Pages.ToString();
                    txtAmount.Text = editingBook.Stock.ToString();
                    dtpPublishDate.Value = editingBook.PublisDate;
                }
                else
                {


                    Book addingBook = lstBooks.SelectedItem as Book;
                    addingBook.Id = Convert.ToInt32(txtBookId.Text);
                    addingBook.Name = txtBookName.Text;
                    addingBook.Author = txtBookAuthor.Text;
                    addingBook.Pages = Convert.ToInt32(txtBookPages.Text);
                    addingBook.Stock = Convert.ToInt32(txtAmount.Text);
                    addingBook.PublisDate = dtpPublishDate.Value;

                    lstBooks.Items.Insert(changingIndex, addingBook);
                    lstBooks.Items.RemoveAt(changingIndex + 1);
                    MessageBox.Show("İşlem Başarılı");
                    ResetCombo();
                    txtBookId.Text = "";
                    txtBookName.Text = "";
                    txtBookAuthor.Text = "";
                    txtBookPages.Text = "";
                    txtAmount.Text = "";
                    dtpPublishDate.Value = DateTime.Now;
                    pnlInput.Visible = false;
                    lstBooks.Enabled = true;
                    btnDeleteBook.Enabled = true;
                    btnAddBook.Enabled = true;
                    BtnBookDetails.Enabled = true;
                    btnAddBook.Text = "Ekle";
                    btnEditBook.Text = "Düzenle";
                }
            }
        }




        void ResetCombo()
        {
            cmbBooks.Items.Clear();
            foreach (var item in lstBooks.Items)
            {
                cmbBooks.Items.Add(item);
            }
        }

        private void btnPickBook_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex !=-1 && cmbBooks.SelectedIndex != -1)
            {
                Book pickingBook = cmbBooks.SelectedItem as Book;
                Student pickingStudent = lstStudents.SelectedItem as Student;

                MessageBox.Show(pickingStudent.PickBook(pickingBook));
            }
        }

        private void btnSeeBooks_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex != -1)
            {
                Student pickingStudent = lstStudents.SelectedItem as Student;

                MessageBox.Show(pickingStudent.BookList());
                lstStudents.SelectedIndex = -1;
            }
        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex != -1)
            {
                cmbTakenBooks.Items.Clear();
                Student pickingStudent = lstStudents.SelectedItem as Student;
                foreach (Book book in pickingStudent.TakenBooks)
                {
                    cmbTakenBooks.Items.Add(book);
                } 
            }
        }

        private void btnLeaveBook_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex != -1 && cmbTakenBooks.SelectedIndex != -1)
            {
                Student pickingStudent = lstStudents.SelectedItem as Student;

                pickingStudent.LeaveBook(cmbTakenBooks.SelectedItem as Book);

                cmbTakenBooks.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Book a = new Book();
            //Book b = new Book();
            //Book v = new Book();
            //Book r = new Book();
            //Book s = new Book();
            //Book k = new Book();

            MessageBox.Show(Book.Sayac.ToString());
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    foreach (Book item in lstBooks.SelectedItems)
        //    {
        //        MessageBox.Show(item.Name);
        //    }
        //}

        //private void lstBooks_Click(object sender, EventArgs e)
        //{
        //    if (lstBooks.SelectedItems.Count>2)
        //    {
        //        lstBooks.SelectedItems.Remove(lstBooks.SelectedItems[lstBooks.SelectedItems.Count-1]);
        //        MessageBox.Show("Daha fazla seçemezsin");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Seçtin");
        //    }
        //}
    }

}
