using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritiance_Uygulama_3_donerci_
{
    public class DonerciUsta:Person
    {
        public DonerciUsta()
        {
            this.Doner = 1200;
            this.Lavas = 20;
            this.Domates = 52;
            this.Stursusu= 20;
            this.Patates = 48;

        }

        public int Doner { get; set; }
        public int Lavas { get; set; }
        public int Domates { get; set;}
        public int Stursusu { get; set; }
        public int Patates { get; set; }

        public string Donerhazirla()
        {
            if (Doner > 200 && Lavas > 1 && Domates > 3 && Stursusu > 2 && Patates > 10)
            {
                Doner-=200; Lavas-=1; Domates-=3;Stursusu-=2; Patates-=10;  
                return "Döner Hazir";
            }

            else
            {
                return "Döner Hazırlanamadı malzeme eksik";
            }
            
        }


    }
}
