using EmlakciOdeviLib;
using System.Collections.Generic;
using System.IO;
using System;
using System.Text;

namespace EmlakciOdeviApp
{
    public class Program
    {
     
   
        private static List<KiralikEvler> kiralikEvler = new List<KiralikEvler>();
        private static List<SatilikEvler> satilikEvler = new List<SatilikEvler>();
        private const string KiralikEvler_dosya_yolu = @"C:\Users\Fatma Nur\OneDrive\Masaüstü\NTP-1_Odevi\EmlakciOdeviApp\KiralikEvler.txt";
        private const string SatilikEvler_dosya_yolu = @"C:\Users\Fatma Nur\OneDrive\Masaüstü\NTP-1_Odevi\EmlakciOdeviApp\SatilikEvler.txt";

        public static void Main(string[] args)
        {
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: (1-Kiralık Ev Bilgileri/2-Satılık Ev bilgileri)");
            int secim = int.Parse(Console.ReadLine());

        BASADON:
            switch (secim)
            {
                case 1:
                    KiralikEvMenu(KiralikEvler_dosya_yolu);
                    break;
                case 2:
                    SatilikEvMenu(SatilikEvler_dosya_yolu);
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim.");
                    goto BASADON;
            }
        }

        private static void KiralikEvMenu(string dosyaYolu)
        {
            Console.WriteLine("Kiralık Ev menüsü açılıyor...");
            Console.ReadKey();
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: (1-Kayıtlı kiralık ev görüntüleme/2-Yeni kiralık ev girişi)");
            int secim = int.Parse(Console.ReadLine());

            if (secim == 1)
            {
                Goruntule<KiralikEvler>(dosyaYolu);
            }
            else if (secim == 2)
            {
                YeniEvGirisi<KiralikEvler>(dosyaYolu);
            }
            else
            {
                Console.WriteLine("Geçersiz seçim.");
            }
        }

        private static void SatilikEvMenu(string dosyaYolu)
        {
            Console.WriteLine("Satılık ev menüsü açılıyor...");
            Console.ReadKey();
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: (1-Kayıtlı satılık ev görüntüleme/2-Yeni satılık ev girişi)");
            int secim = int.Parse(Console.ReadLine());

            if (secim == 1)
            {
                Goruntule<SatilikEvler>(dosyaYolu);
            }
            else if (secim == 2)
            {
                YeniEvGirisi<SatilikEvler>(dosyaYolu);
            }
            else
            {
                Console.WriteLine("Geçersiz seçim yaptınız.");
            }
        }

        private static void Goruntule<T>(string dosyaYolu) where T : Evler, new()
        {
            Console.WriteLine("Kayıtlı evler görüntüleniyor...");
            string metin = File.ReadAllText(dosyaYolu);
            Console.Write(metin);
            Console.ReadLine();
        }

        private static void YeniEvGirisi<T>(string dosyaYolu) where T : Evler, new()
        {
            Console.WriteLine("Yeni ev bilgileri giriniz:");
            T yeniEv = new T();
            yeniEv.BilgileriGir();


            Console.Write("Bilgiler kaydedilsin mi? (E/H)");
            string cevap = Console.ReadLine().ToUpper();

            if (cevap == "E")
            {
                string yeniEvBilgisi = yeniEv.ToString();
                using (StreamWriter dosya = new StreamWriter(dosyaYolu, true))
                {
                    dosya.WriteLine(yeniEvBilgisi);
                    Console.WriteLine("Bilgiler istenilen şekilde kaydedildi.");
                }
            }
            else
            {
                Console.WriteLine("Kaydetme işlemi yapılmadı!Lütfen istenilen şekilde işlem yapınız!!");
            }
        }
    }

   
    

}















