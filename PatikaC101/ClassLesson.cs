using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101
{
    public static class ClassLesson
    {
        public static void calisma()
        {
            Calisan calisan1 = new Calisan();
            calisan1._ad = "Emre";
            calisan1._soyad = "Pirvan";
            calisan1._no = 676876868;
            calisan1._departman = "Yazilim Geliştirme";
            calisan1.CalisanBilgileri();
            Console.WriteLine("-----------------------------------------");

            Calisan calisan2 = new Calisan();
            calisan1._ad = "Mehmet";
            calisan1._soyad = "Gunes";
            calisan1._no = 676874343;
            calisan1._departman = "Satin alma";
            calisan1.CalisanBilgileri();

        }
    }
    class Calisan
    {
        public string _ad, _soyad, _departman;
        public int _no;

        public void CalisanBilgileri()
        {
            Console.WriteLine($"Calisan adi {_ad}");
            Console.WriteLine($"Calisan Soyadi {_soyad}");
            Console.WriteLine($"Calisan no {_no}");
            Console.WriteLine($"Calisan departman {_departman}");
        }
    }
}

//Sınıf erişim belirteçleri
// public : Her yerden erişilebilir
// private : sadece tanımlandığı sınıf içerisinde erişilebilen property ve metotlara
// internal : sadece o proje içerisinde erişilebilen property ve metotlara 
// Protected : sadece tanımlandığı sınıfta ve/veya o sınıfı kalıtım alan sınıflarda erişilebilir