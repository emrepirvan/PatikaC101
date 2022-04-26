using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101
{
    public class inheritance
    {
        ///Kalıtımı engellemek istiyorsa Sealed anahtar kelimesi kullanırızs
        public static void Cozum()
        {
            TohumluBitkiler tohumluBitki=new TohumluBitkiler();
            tohumluBitki.TohumlaCogalma();
            Console.WriteLine("------------------------------------------");
            Kuslar martı = new Kuslar();
            martı.Ucmak();
        }
    }

    public class Canlilar
    {
        protected void Beslenme()      {  Console.WriteLine("Canlilar beslenir");}
        protected void Solunum()       { Console.WriteLine("Canlilar Solunum yapar"); }
        protected void Boşaltılm()      { Console.WriteLine("Canlilar boşaltım yapar"); }
        public virtual void UyaranlaraTepki() { Console.WriteLine("Canlilar Uyaranlara tepki verir"); }
    }
    public class Hayvanlar : Canlilar
    {
        protected void Adaptasyon() { Console.WriteLine("Hayvanlar adaptasyon yapar"); }
        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar Temasa tepki verir");
        }
    }
    public class Bitkiler : Canlilar
    {
        protected void Fotosentez() { Console.WriteLine("Bitkiler fotosentez yapar"); }
        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            //Console.WriteLine("Bitkiler Güneşe tepki verir");
        }
    }
    public class TohumluBitkiler : Bitkiler
    {
        public TohumluBitkiler()
        {
            base.Fotosentez();
            base.Solunum();
            base.Beslenme();
            base.Boşaltılm();
            base.UyaranlaraTepki();
        }
        public void TohumlaCogalma() { Console.WriteLine("Tohumlu bitkiler tohumla coğalır"); }
    }
    public class TohumsuzBitkiler : Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.Fotosentez();
            base.Solunum();
            base.Beslenme();
            base.Boşaltılm();
        }
        public void TohumsuzCogalma() { Console.WriteLine("Tohumsuz bitkiler Sporla coğalır"); }
    }
    public class Surungenler : Hayvanlar
    {
        public Surungenler()
        {
            base.Adaptasyon();
            base.Solunum();
            base.Beslenme();
            base.Boşaltılm();
        }
        public void SurunerekHaraketEder() { Console.WriteLine("Surungenler Surunerek haraket eder"); }
    }
    public class Kuslar : Hayvanlar
    {
        public Kuslar()
        {
            base.Adaptasyon();
            base.Solunum();
            base.Beslenme();
            base.Boşaltılm();
            base.UyaranlaraTepki();
        }
        public void Ucmak() { Console.WriteLine("Kuslar Ucar"); }
    }
}
