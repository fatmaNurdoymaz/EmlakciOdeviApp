using System;
using System.Collections.Generic;
using System.Text;

namespace EmlakciOdeviLib
{
    public class SatilikEvler:Evler
    {
        public SatilikEvler() : base() { }

        public SatilikEvler(int odasayisi,double alan,sbyte katno,string semt,double satisfiyati) :base(odasayisi,alan,katno,semt)
        {
            this.SatisFiyati = satisfiyati;
        }
        public double SatisFiyati { get; set; }
        public override void BilgileriGir()
        {
            Console.Write("Oda sayısı:");
            Odasayisi = int.Parse(Console.ReadLine());
            Console.Write("Kat Numarası:");
            Katno = (sbyte)int.Parse(Console.ReadLine());
            Console.Write("Alan:");
            Alan = double.Parse(Console.ReadLine());
            Console.Write("Semt:");
            Semt = Console.ReadLine();
            Console.Write("Satış fiyatı:");
            SatisFiyati = double.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nSatış fiyatı: {SatisFiyati}TL\n";
        }


    }
}
