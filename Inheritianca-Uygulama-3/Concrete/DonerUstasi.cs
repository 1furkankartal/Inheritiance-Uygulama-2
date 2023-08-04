using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritianca_Uygulama_3.Concrete
{
    internal class DonerUstasi
    {
        public bool SiparisHazirla(double doner,int lavas,int domates, int salatalik,int patates,int siparissayisi)
        {
            if (doner >= 200*siparissayisi && lavas >= 1*siparissayisi && domates >= 3*siparissayisi && salatalik >= 2*siparissayisi && patates >= 10*siparissayisi)
            {
                Console.WriteLine("Sipariş hazır");
                return true;
            }
            else
            {
                Console.WriteLine("Malzeme Yok Sipariş Hazırlanamz");
                return false;
            }
        }
    }
}
