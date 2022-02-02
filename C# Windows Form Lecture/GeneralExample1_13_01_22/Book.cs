using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSessionWindowsOOP.GeneralExample1_13_01_22
{
    class Book
    {

        public Book()
        {
            sayac++;
        }

        static int sayac;
        public static int Sayac { get { return sayac; } }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        private int pages;

        public int Pages
        {
            get { return pages; }
            set { pages = value; }
        }

        private int stock;

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        private DateTime publishDate;

        public DateTime PublisDate
        {
            get { return publishDate; }
            set { publishDate = value; }
        }

        public string Display { get { return  Id + "-" + Name; } }

    }
}
