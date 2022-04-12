using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101
{
    public class Overloading
    {
        public static void outparametreler()
        {
            //Out parametreler
            string sayi = "999";
            int outSayi;

            bool sonuc = int.TryParse(sayi, out outSayi);
            if (sonuc)
            {
                Console.WriteLine("başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("başarısız");
            }
        }
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }
        //Overloading bir fonksiyonun imzasını değiştirerek birden fazla şekilde o fonksiyonu kullanabiliriz;
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);  // şuan bu fonksiyon string veriyi alıp ekrana yazdırabilir peki int tipi de yazdırmak istersek?
        }
        public void EkranaYazdir(int veri)// Fonksiyonu overload ettik 
        {
            Console.WriteLine(veri);  //Artık integer ifadede yazdırabilir
        }
        ///Metot imzası
        ///metotAdı + parametre sayisi + parametre ------> bunların 3'u aynı olduğunda bize kızar
        public void EkranaYazdir(int veri1, int veri2)// Fonksiyonu tekrar overload ettik 
        {
            Console.WriteLine(veri1+ " " + veri2); 
        }
    }
}