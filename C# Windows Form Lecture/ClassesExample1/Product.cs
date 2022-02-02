using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSessionWindowsOOP.ClassesExample1
{
    class Product
    {
        public Product()
        {

        }

        public Product(int _id, string _name, double _price, string _type)
        {
            id = _id;
            name = _name;
            price = _price;
            type = _type;
        }

        public int id;
        public string name;
        public double price;
        public string type;


        public double DovizFiyat(string currencyName)
        {
            switch (currencyName)
            {
                case "Dolar":
                    return price / 10;
                case "Euro":
                    return price / 15;
                case "Sterlin":
                    return price / 20;
                case "Yen":
                    return price * 15;
                case "Ruble":
                    return price * 30;
                default:
                    return price;
            }
        }
    }
}
