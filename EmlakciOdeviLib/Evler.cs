using System;


namespace EmlakciOdeviLib
{
    public abstract class Evler
    {
        public int Odasayisi { get; set; }
        public double Alan { get; set; }
        public sbyte Katno { get; set; }
        public string Semt { get; set; }

        public abstract void BilgileriGir();

        protected Evler() { }


        public  Evler(int odasayisi,double alan,sbyte katno,string semt) 
        {
            Odasayisi = odasayisi;
            Alan = alan;
            Katno = katno;
            Semt = semt;

        }
        public override string ToString()
        {
            return $"Oda Sayısı:{this.Odasayisi}\n Alan:{this.Alan}\n Kat No:{this.Katno}\n Semt:{this.Semt}";
        }

    }
}
