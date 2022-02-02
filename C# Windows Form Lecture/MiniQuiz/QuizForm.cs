using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeSessionWindowsOOP.MiniQuiz
{
    public partial class QuizForm : Form
    {
        public QuizForm()
        {
            InitializeComponent();
        }

        private void btnMesaj_Click(object sender, EventArgs e)
        {
            QuizClass quiz = new QuizClass("Ebru");
            //quiz.name = "Ebru";
            quiz.Id = "1";
            MessageBox.Show(quiz.Id.ToString());

            lstQuiz.Items.Add(quiz);
        }

        private void QuizForm_Load(object sender, EventArgs e)
        {
            lstQuiz.DisplayMember = "Mahmut";
        }
    }
}
