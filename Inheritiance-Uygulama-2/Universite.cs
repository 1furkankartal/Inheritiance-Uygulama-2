using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritiance_Uygulama_2
{
    internal class Universite
    {
        public Universite()
        {
            Calisanlar=new List<Calisan> ();
        }

        public string UniversiteAd { get; set; }
        public string Adress { get; set; }
        public List<Calisan> Calisanlar { get; set; }   
        public void DersVer(Ogrenci ogrenci)
        {
            Console.WriteLine(ogrenci.Ad+"ders aldı");
        }

        public void CalisanEvragiVer(Calisan calisan)
        {
            Console.WriteLine($"{calisan.Ad}{calisan.Soyad} kişisi üniversitemizde çalışmaktadır.");
        }


    }
}
