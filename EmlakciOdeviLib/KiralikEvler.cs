using System;
using System.Collections.Generic;
using System.Text;

namespace EmlakciOdeviLib
{
    public class KiralikEvler:Evler  
    {
        public KiralikEvler() : base() { }
        public KiralikEvler(int odasayisi,double alan,sbyte katno,string semt,double kira,double depozito):base(odasayisi,alan,katno,semt)
        {
            this.Kira = kira;
            this.Depozito = depozito;
        }
        public double Kira { get; set; }
        public double Depozito { get; set; }
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
            Console.Write("Kira:");
            Kira = double.Parse(Console.ReadLine());
            Console.Write("Depozito:");
            Depozito = double.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nKira: {Kira}TL\nDepozito: {Depozito}TL\n";
        }

    }

}
