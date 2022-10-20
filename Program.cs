using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı:{0}",Calisan.CalisanSayisi);
            Calisan calisan1=new Calisan("Ayşe","yılmaz","İK");
            Console.WriteLine("Çalışan sayısı:{0}",Calisan.CalisanSayisi);
            Calisan calisan2=new Calisan("Deniz","Arda","İK");
            Calisan calisan3=new Calisan("Zikriye","Ürkmez","İK");
            Console.WriteLine("Çalışan sayısı:{0}",Calisan.CalisanSayisi);          
            
            Console.WriteLine("Toplama işlemi sonucu:{0}",Islemler.Topla(100,200));            
            Console.WriteLine("Toplama işlemi sonucu:{0}",Islemler.Cikar(400,50));
        }
    }

    class Calisan
    {
        private static int calisanSayisi;
        private string Isim;
        private string Soyisim;
        private string Departman;

        public static int CalisanSayisi { get => calisanSayisi; }

        static Calisan() // statik Constructor a sadece ilk defada girer. ondan sonra girmez.
        {
            calisanSayisi=0;
        }
        public Calisan(string ısim, string soyisim, string departman)
        {
            this.Isim = ısim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }
    
    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1+sayi2;
        }
        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1-sayi2;
        }
    }
}
