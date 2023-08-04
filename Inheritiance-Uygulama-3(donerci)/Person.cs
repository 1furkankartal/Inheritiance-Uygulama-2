using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritiance_Uygulama_3_donerci_
{
    public class Person
    {
        public string Ad { get; set; }
        public string Soyisim { get; set; }
        public string TelefonNo { get; set; }
        public string Adres { get; set; }
    }
}










/*          
           
            / Döner,  Lavaş, Domates dilimleri, Salatalık Turşusu   Patates dilimleri 
            // Dönerci dükkanı ilk açıldığında bütün ürünlerin ne kadar olduğu belirleniyor.

            // - İŞLEYİŞ
            // Müşteri kaç tane dürüm istediğini sipariş verir. Garson siparişi alır. Döner Ustası da siparişi hazırlar. sonra Garson bu siparişi Müşteriye götürür.
            // Döner Ustası siparişi hazırlarken stoklara bakar ve stoklarda dürüm yapacak kadar malzeme var ise siparişi hazırlar.

            // - DETAYLAR
            // Garson her aldığı sipariş için 1₺ prim alıyor.
            // Her bir sipariş de Döner'den 200gr,Lavaş dan 1 adet, Domates Dilimlerinden 3 adet, Salatalık Turşusundan 2 adet, Patates Dilimlerinden 10 adet kullanılıyor. Eğer stokta bu kadar ürün yok ise Sipariş hazırlanamıyor.
            // Müşteri, Garson ve Döner Ustasının İsim soy isim, Telefon ve Adres bilgileri var

            // - EKSTRA
            // Donerci Dükkanının bir beğeni oranı var.
            // Müşteri bu Dönerci Dükkanına puan verebilir.
             */
