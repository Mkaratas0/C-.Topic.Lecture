using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSessionWindowsOOP.Inheritance
{
    class Urunler//BASE CLASS
    {
        public int id;
        public double fiyat;
        public int degerlendirmePuani;

        public virtual void FiyatHesapla()
        {
            return;
        }

        public virtual string Ozet { get; set; }
    }

    class Telefon : Urunler
    {
        public Telefon()
        {

        }
        public Telefon(int _id, double _fiyat, int _deger, int _on, int _batarya, string sarj)
        {
            id = _id;
            fiyat = _fiyat;
            degerlendirmePuani = _deger;
            onKamera = _on;
            batarya = _batarya;
            sarjGirisi = sarj;

            FiyatHesapla();
        }

        public int onKamera;
        public int batarya;
        public string sarjGirisi;


        public override void FiyatHesapla()
        {
            fiyat = fiyat * onKamera;
        }

        public override string Ozet { get => id + " " + onKamera + " " + batarya + " " + sarjGirisi; }
    }

    class MasaustuPc : Urunler
    {
        public MasaustuPc()
        {

        }
        public MasaustuPc(int _id, double _fiyat, int _deger, bool _rgb, int _ssd, string _isletim)
        {
            id = _id;
            fiyat = _fiyat;
            degerlendirmePuani = _deger;
            rgbIsiklandirma = _rgb;
            ssd = _ssd;
            isletimSistemi = _isletim;

            FiyatHesapla();
        }



        public bool rgbIsiklandirma;
        public int ssd;
        public string isletimSistemi;



        public override void FiyatHesapla()
        {
            if (rgbIsiklandirma)
            {
                fiyat *= 2;
            }
            else
            {
                return;
            }
        }

        public override string Ozet { get => id + " " + rgbIsiklandirma + " " + ssd + " " + isletimSistemi; }
    }
}
