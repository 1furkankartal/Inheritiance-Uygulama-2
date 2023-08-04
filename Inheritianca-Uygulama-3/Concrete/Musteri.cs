using Inheritianca_Uygulama_3.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritianca_Uygulama_3.Concrete
{
    internal class Musteri:Kisi
    {
        public int SiparisVer()
        {
            Console.WriteLine("Hoşbuldukks Siparişim şudur");
            int siparisSayisi = int.Parse(Console.ReadLine());
            return siparisSayisi;
        }

        
    }
}
