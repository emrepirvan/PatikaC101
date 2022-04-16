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

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(degisken.Split(' ')[1]); // Boşluk olan yerlerden parçala 1. elemanı getir
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine(degisken.Substring(4));  // 4. İNDEXten başlayarak sonuna kadar getir
            Console.WriteLine(degisken.Substring(4, 6));  // 4. İNDEXten başlayarak sonuna kadar getir
        }

        public static void HackerRankTest()
        {
            int n = int.Parse(Console.ReadLine());
            string ifade;
            for (int i = 0; i < n; i++)
            {
                ifade = Console.ReadLine();

                EvenOddString(ifade);
            }
        }
        public static void EvenOddString(string ifade)
        {
            string evenStr = "";
            string oddStr = "";
            for (int i = 0; i < ifade.Length; i++)
            {
                if (i % 2 == 0)
                {
                    evenStr += ifade[i];
                }
                else if (i % 2 == 1)
                {
                    oddStr += ifade[i];
                }
            }
            Console.WriteLine(evenStr + " " + oddStr);

        }

        public static void DateTimeMetotlar()
        {
            Console.WriteLine(DateTime.Now);  //Günün tarihini getirir
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine(DateTime.Now.ToShortTimeString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(1));
            Console.WriteLine(DateTime.Now.AddYears(4));
            Console.WriteLine(DateTime.Now.AddMilliseconds(5000));


            ///date time format
            Console.WriteLine(DateTime.Now.ToString("dd")); ///16
            Console.WriteLine(DateTime.Now.ToString("ddd")); ///sat
            Console.WriteLine(DateTime.Now.ToString("dddd")); ///saturday
            Console.WriteLine(DateTime.Now.ToString("MM")); ///04
            Console.WriteLine(DateTime.Now.ToString("MMM")); ///APR
            Console.WriteLine(DateTime.Now.ToString("MMMM")); ///April
            Console.WriteLine(DateTime.Now.ToString("yy")); ///22
            Console.WriteLine(DateTime.Now.ToString("yyy")); ///2022
        }

        public static void MathMetotlar()
        {
            Console.WriteLine(Math.Abs(-25)); //25

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(Math.Ceiling(2.5)); //3    yukarıya yuvarlar
            Console.WriteLine(Math.Round(2.4)); //2     En yakına yuvarlar
            Console.WriteLine(Math.Round(2.7)); //2     En yakına yuvarlar  
            Console.WriteLine(Math.Floor(2.9)); //2     Aşağıya yuvarlar
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine(Math.Max(2,4));
            Console.WriteLine(Math.Min(2, 4));
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine(Math.Pow(2, 3));  // üs alma
            Console.WriteLine(Math.Sqrt(2));   // karakök alır
            Console.WriteLine(Math.Log(2));   // Logaritma  e tabanında 2 nin karşılığı
            Console.WriteLine(Math.Exp(3));   // e üzeri 3
            Console.WriteLine(Math.Log10(10));   // Logaritma 10 tabanında 10 karşılığı


            Console.WriteLine("-------------------------------------------");
        }
    }
}