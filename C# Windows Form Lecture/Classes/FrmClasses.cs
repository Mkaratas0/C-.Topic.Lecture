using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeSessionWindowsOOP.Classes
{
    public partial class FrmClasses : Form
    {
        public FrmClasses()
        {
            InitializeComponent();
        }
        private void FrmClasses_Load(object sender, EventArgs e)
        {

        }

        List<Students> allStudents = new List<Students>();

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            if (InputControl())
            {
                Students student = new Students(Convert.ToInt32(txtNum.Text), (int)nmrGrade.Value, txtName.Text, txtSurname.Text);
                allStudents.Add(student);
                lstStudents.Items.Add(student.studentNo);
            }
            else
            {
                MessageBox.Show("Hata");
            }
        }

        bool InputControl()
        {
            if (txtName.Text == "" || txtSurname.Text == "" || txtNum.Text == "")
            {
                return false;
            }
            try
            {
                int control = Convert.ToInt32(txtNum.Text);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        //type 
        Students FindStudent(int studentNumber)
        {
            Students donulecekStudent = new Students();

            foreach (Students listedekiSudent in allStudents)
            {
                if (listedekiSudent.studentNo == studentNumber)
                {
                    donulecekStudent = listedekiSudent;
                }
            }
            return donulecekStudent;
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FindStudent(2323).ToString());
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Students kitapEklenecekOgrenci = FindStudent(Convert.ToInt32(lstStudents.SelectedItem));
            kitapEklenecekOgrenci.doesHave = true;
            kitapEklenecekOgrenci.startDate = DateTime.Now;
            kitapEklenecekOgrenci.endDate = DateTime.Now.AddDays((double)15);
            kitapEklenecekOgrenci.takenBookName = cmbBooks.SelectedItem.ToString();
        }

        private void btnDoesHave_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex != -1)
            {
                if (FindStudent(Convert.ToInt32(lstStudents.SelectedItem)).doesHave)
                {
                    MessageBox.Show("Kitap almış.");
                }
                else
                {
                    MessageBox.Show("Mevcut kitabı yok.");
                }
            }
            else
            {
                MessageBox.Show("Öğrenci seç.");
            }
        }

        private void btnTimeLeft_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FindStudent(Convert.ToInt32(lstStudents.SelectedItem)).TimeLeft.ToString());
        }
    }
}
