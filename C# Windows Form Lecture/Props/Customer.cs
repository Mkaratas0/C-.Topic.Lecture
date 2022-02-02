using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSessionWindowsOOP.Props
{
    class Customer
    {

        public Customer()
        {
            basket = new List<CusProduct>();
        }
        string nameSurname;
        double balance;//cüzdan/bakiye
        int coupons;

        //Şuan gereksiz
        int couponProgress;
        public int CouponProgress
        {
            get { return couponProgress; }
            set { couponProgress = value; }
        }

        public string Password { get { return "123"; } }

        public string NameSurname
        {
            get
            {
                return nameSurname;
            }
            set
            {
                if (value.Trim() == "")
                {
                    nameSurname = "İsim Girilmedi";
                }
                else
                {
                    nameSurname = value;
                }
            }
        }

        public double Balance { get { return balance; } set { if (value < 0) balance = 0; else balance = value; } }

        public int Coupons { get { return coupons; } set { if (value < 0) coupons = 0; else if (value > 5) coupons = 5; else coupons = value; } }




        List<CusProduct> basket;

        public List<CusProduct> Basket { get { return basket; } }

    }

    class CusProduct
    {

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

        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        int couponValue;

        public int CouponValue
        {
            get
            {
                if (price >= 5000 && price < 10000)
                {
                    couponValue = 1;
                    return couponValue;
                }
                else if (price >= 10000)
                {
                    couponValue = 2;
                    return couponValue;
                }
                else
                {
                    couponValue = 0;
                    return couponValue;
                }
            }
        }

        public string Display { get { return id + " " + name; } }
    }

}
