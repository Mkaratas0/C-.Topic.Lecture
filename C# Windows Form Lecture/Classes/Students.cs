using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSessionWindowsOOP.Classes
{
    //Instance almak o classtan bir obje oluşturmak demektir.
    class Students
    {
        public Students() 
        {
        }
        public Students(int sNo, int sGrade, string sName, string sSurname)
        {
            studentNo = sNo;
            grade = sGrade;
            name = sName;
            surName = sSurname;
        }

        public int studentNo;
        public int grade;
        public string name;
        public string surName;

        public bool doesHave;
        public string takenBookName;
        
        public DateTime startDate;
        public DateTime endDate;

        public int TimeLeft { get { return endDate.Subtract(DateTime.Now).Days;} }//substract bir tarihle başka bir tarih arasındaki süreyi verir
    }
}
