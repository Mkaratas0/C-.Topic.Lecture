using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSessionWindowsOOP.GeneralExample1_13_01_22
{
    class Student
    {
        private int studentNo;

        public int StudentNo
        {
            get { return studentNo; }
            set { studentNo = value; }
        }


        private string nameSurname;

        public string NameSurname
        {
            get { return nameSurname; }
            set { nameSurname = value; }
        }

        private int studentClass;

        public int StudentClass
        {
            get { return studentClass; }
            set
            {
                if (value > 0 && value <= 4)
                {
                    studentClass = value;
                }
                else
                {
                    studentClass = 1;
                }
            }
        }

        List<Book> takenBooks = new List<Book>();
        public List<Book> TakenBooks { get { return takenBooks; } }
        public string PickBook(Book book)
        {
            if (takenBooks.Count < 2)
            {
                takenBooks.Add(book);
                return "Kitap eklendi";
            }
            else
            {
                return "2 den fazla kitap alamaz";
            }
        }

        public string LeaveBook(Book book)
        {
            if (takenBooks.Count > 0 && book != null)
            {
                takenBooks.Remove(book);
                return "Kitap çıkarıldı";
            }
            else
            {
                return "Zaten Kitabı Yok";
            }
        }

        public string BookList()
        {
            string bookList = "";

            foreach (Book book in takenBooks)
            {
                bookList += book.Display + "\n";
            }
            bookList += "Öğrencinin mevcut kitap sayısı: " + takenBooks.Count; 
            if (bookList == "")
            {
                return "Kitap bulunamadı";
            }
            else
            {
                return bookList;
            }
        }
    }
}
