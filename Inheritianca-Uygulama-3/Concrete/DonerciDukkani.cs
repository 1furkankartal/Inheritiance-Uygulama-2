using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritianca_Uygulama_3.Concrete
{
    internal class DonerciDukkani
    {
        public Garson Garson { get; set; }
        public  DonerUstasi DonerUstasi { get; set; }

        public double DonerKg { get; set; } 
        public int Lavas { get; set; }
        public int Domates { get; set; }
        public int Salatalik { get; set; }
        public int Patates { get; set; }
        public bool Dükkanacikmi { get; set; }
        // public bool Dükkanacikmi { get; set; } = false;

        public DonerciDukkani(double donerkg, int lavas, int domates, int salatalik, int patates) // NESNE OLUŞTURULURKEN BAŞTAN İSTİYOR 
        {
            this.DonerKg= donerkg;
            this.Lavas= lavas;
            this.Domates = domates;
            this.Salatalik= salatalik;  
            this.Patates= patates;
            this.Dükkanacikmi = false;
        }
        public void DukkaniAc()
        {
            Console.WriteLine("Dükkan Açıldı");
            this.Dükkanacikmi = true;
        }
        public void DukkaniKapat()
        {
            Console.WriteLine("dukkan kapatilmiştir.");
            this.Dükkanacikmi = false;
        }

        public void MusteriGeldi(Musteri musteri)
        {
            if (this.Dükkanacikmi)
            {
               int siparis=  this.Garson.SiparisAl(musteri);
               bool siparisHazirMi= this.DonerUstasi.SiparisHazirla(this.DonerKg,this.Lavas,this.Domates,this.Salatalik,this.Patates,siparis);

                if(siparisHazirMi)
                {
                    this.Garson.SiparisiGotur(musteri);
                }
                else
                {
                    this.Garson.OzurDile(musteri);
                }
            }
            else
            {
                Console.WriteLine("dukkan henuz açılmadı");
            }
        }
    }
}
