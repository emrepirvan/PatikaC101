using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101
{
    public static class HazirMetotlar
    {
        public static void StringMetotlar()
        {
            string degisken = " Dersimiz Csharp, Hoşgeldiniz \n \n";
            string degisken2 = "Csharp";

            Console.Write("Karakter sayısı  " + degisken.Length);

            Console.WriteLine("Karakterlerin hepsini büyük harf yapar : " + degisken.ToLower());
            Console.WriteLine("Karakterlerin hepsini küçük harf yapar : " + degisken.ToUpper());


            Console.WriteLine(" Sonuna yeni karakter ekleme yapar :" + string.Concat(degisken, " Merhaba! \n"));


            Console.WriteLine("if degisken1=degisken2 == 0 ,\nelse if degisken1>degisken2 == 1 \ndegisken1<degisken2 == -1 \n" + degisken.CompareTo(degisken2));
            Console.WriteLine(string.Compare(degisken, degisken2, true));  ///ignore case durumu bu iki degiskeni karşılaştırırkeen büyük küçük harf durumununu kontrol eder
            //True dersek büyük küçük harf duyarsız hale gelir, False duyarlı olur.


            Console.WriteLine(degisken.Contains(degisken2));

            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));

            Console.WriteLine(degisken.IndexOf("Cs"));  // karakterin bulunduğu index degerini döner1

            Console.WriteLine(degisken.IndexOf("sad")); //Hiçbir şey bulamazsa -1 döner

            Console.WriteLine(degisken.Insert(0, "MERHABA ! "));  //istediğimiz index'e  yazı insert ettik

            Console.WriteLine(degisken + degisken2.PadLeft(30));   // Soldan 30 karakter boşluk bıraktı
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*')); // Soldan 30 karakter * koydu
            Console.WriteLine(degisken.PadRight(50) + degisken2); // sağdan 30 karakter boşluk bıraktı
            Console.WriteLine(degisken.PadRight(50, '-') + degisken2.PadLeft(30)); // sağdan 30 karakter tire koydu



            Console.WriteLine(degisken.Remove(10)); //10.indexten sonrasını siler
            Console.WriteLine(degisken.Remove(5, 3)); //5.indexten başlayarak 3 karakter siler
            Console.WriteLine(degisken.Remove(0, 1)); //0.indexten başlayarak 1 karakter siler


            Console.WriteLine(degisken.Replace("Csharp", "C#"));// ilk verdiğimiz değerle ikincisini yer degistirir
            Console.WriteLine(degisken.Replace(" ", "*"));// ilk verdiğimiz değerle ikincisini yer degistirir


            Console.WriteLine(degisken.Split(' ')[1]); // Boşluk olan yerlerden parçala 1. elemanı getir


            Console.WriteLine(degisken.Substring(4));  // 4. İNDEXten başlayarak sonuna kadar getir
            Console.WriteLine(degisken.Substring(4, 6));  // 4. İNDEXten başlayarak sonuna kadar getir
        }
    }
}