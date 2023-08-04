using Inheritianca_Uygulama_3.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritianca_Uygulama_3.Concrete
{
    internal class Garson:Kisi
    {
        public int Prim { get; private set; }
        public int SiparisAl(Musteri musteri)
        {
            Console.WriteLine("Hoşgeldiniz siparişiniz nedir?");
           int siparisSayisi= musteri.SiparisVer();
            this.Prim++;
            return siparisSayisi;
        }

        public void SiparisiGotur(Musteri musteri)
        {
            Console.WriteLine("Musteri afiyet olsunnsss");
        }

        public void OzurDile(Musteri musteri)
        {
            Console.WriteLine("Özür dileriizz...");
        }


    }
}
