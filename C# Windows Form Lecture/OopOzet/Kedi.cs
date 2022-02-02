using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeSessionWindowsOOP.OopOzet
{
    class EvHayvanlari//BASE CLASS
    {
        public int yas;
        public string isim;
        public string cins;
        public Color renk;
        public float kilo;

        public virtual string Ses()//virtual member miras alan classa göre yeniden şekillenir
        {
            return "";
        }
    }
    class Kedi : EvHayvanlari
    {

        public Kedi()
        {
            //Obje ilk
        }
        //Obje programlamada kullandığımız herşeydir.
        //Nesne tabanlı programlamada nesneler ön plandadır 
        //Nesneler class yoluyla belirlenir ve oluşturulur
        //Classlar nesnelerin özelliklerini, işlevlerini,kullanım amaçlarını ve davranış biçimlerini oluşturur
        // class içinde tanımlanan değişkene field denir
        public string sahibi;
        public bool YetiskinMi { get; set; }

        int asiSayisi;
        public int AsiSayisi { get => asiSayisi; }

        int a;
        public int A
        {
            get { return a; }
            set
            {
                if (value == 8)
                { }
                else
                {
                    a = value;
                }
            }
        }//Encapsulation , class içerisindeki verilerin kontrol altında olması dış etkenlerden saklanması ve güvenliği işlemidir
         //buradaki işlemde a sayısının 8 sayısına eşitlenmesi propertynin set metodunda engellendi. Buna encapsulation denir

        public override string Ses()
        {
            return "miyav";
        }

    }
    class Kopek : EvHayvanlari
    {
        public override string Ses()//Base classtaki virtual memberı değiştirmek için onu override etmemiz gerekir
        {
            return "Hav";
        }
    }
    static class Messages
    {

        public static string Hello { get => "Merhaba"; }
        public static string Bye { get => "Güle güle"; }
        public static string HowAreYou { get => "Nasılsın"; }

        static List<string> tumMesajlar = new List<string> { Hello, Bye, HowAreYou };

        public static int TumMesajlar { get; }

        public static string MesajBirlestir(int index1, int index2)
        {
            try
            {
                return tumMesajlar[index1] + tumMesajlar[index2];
            }
            catch (Exception)
            {

                return "";
            }
        }
    }


    abstract class AnaSoyutClass
    {
        public abstract void Calistir();
    }

    class MirasYediClass : AnaSoyutClass
    {
        public override void Calistir()
        {
            System.Windows.Forms.MessageBox.Show("Selam");
        }
    }
    class MirasYemediClass : AnaSoyutClass
    {
        public override void Calistir()
        {
            Form form = new Form();
            form.Show();
        }
    }
}
