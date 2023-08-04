using Inheritiance_Uygulama_2;

internal class Program
{
    private static void Main(string[] args)
    {
        Universite universite= new Universite();
        universite.UniversiteAd = "İstanbul Üniversitesi";

        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Ad = "ahmet";
        ogrenci.Soyad = "yılmaz";

        Egitmen egitmen= new Egitmen();
        egitmen.Ad = "fatih";
        egitmen.Soyad = "alkan";

        Guvenlik guvenlik =new Guvenlik();
        guvenlik.Ad="furkan",
        guvenlik.Soyad = "kartal";

        universite.DersVer(ogrenci);

        universite.CalisanEvragiVer(egitmen);
        universite.CalisanEvragiVer(guvenlik);

    }
}