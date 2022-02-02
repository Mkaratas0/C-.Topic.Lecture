using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSessionWindowsOOP
{
    class Ogrenci
    {
        public int yas;
        public string ad;
        public DateTime dogumTarihi;
        public int sinif;
    }
    class Products
    {
       public double price;
       public string name;
       public string model;
       public DateTime productionDate;
       public string category;
       public string color;


        public void Discount(double amount)
        {
            double discount = (price * amount) / 100;
            price -= discount;
        }
    }
}
