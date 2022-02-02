using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSessionWindowsOOP.AccessModifiers
{
    class ModifierClass
    {
        public int HerkeseAcik { get; set; }//Heryerden herkes ulaşabilir

        private int Gizli { get; set; }//Sadece tanımlandığı class içerisinde kullanılabilir ve ulaşılabilir
        int a;//başında erişim belirleyici yoksa otomatik private

        protected int MirasAlınabilen { get; set; }// Sadece tanımlandığı class içerisinde ve bu classı miras alan classlar içerisinde erişilebilir

        internal int ProjeyeOzel { get; set; }//Sadece bulunduğu projede kullanılabilir başka projelere geçemez

        //sealed int Muhurlu { get; set; }//Miras alınamaz

       
    }
}
