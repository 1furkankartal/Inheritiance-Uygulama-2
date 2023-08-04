using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritiance_Uygulama_3_donerci_
{
    public class Garson:Person
    {
        public int SiparisAl()
        {
            Console.WriteLine("Hoşgeldin");
            Console.WriteLine("kaç dürüm istersin");
            int donersayisi = int.Parse(Console.ReadLine());

            for (int i = 0; i < donersayisi; i++)
            {
                DonerciUsta.DonerHazirla();
            }
            return donersayisi;


        }


    }

}
