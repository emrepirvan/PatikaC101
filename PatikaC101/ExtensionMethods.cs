using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101
{


    public static class ExtensionMethods
    {
        /// <summary>
        /// String ifade de boşluk olup olmadığını kontrol eder
        /// </summary>
        /// <param name="param">String Parametre</param>
        /// <returns>T/F Sonuc</returns>
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");   // boşluk olan yerlerden ayırıp, 
            return string.Join("", dizi);    //Birleştirdik
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void EkranaYazdir(this int[] param)
        {
            foreach (int i in param)
            {
                Console.WriteLine(i);
            }
        }
        public static void EkranaYazdir(this int param)
        {
            Console.WriteLine(param);

        }
        public static void EkranaYazdir(this bool param)
        {
            Console.WriteLine(param);
        }
        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        }
        public static string GetFirtsCharacter(this string param)
        {
            return param.Substring(0, 1);
        }
    }
}
////Rekürisif - Öz yinelemeli Fonksiyonlar
////3^4 = 3*3*3*3
//int result = 1;

//for (int i = 0; i < 4; i++)
//{
//    result = result * 3;
//}
//Console.WriteLine(result);

//Console.WriteLine("----------------------------------------------------------------------");
//RecursiveMethods instance = new();
//Console.WriteLine(instance.Expo(3, 4));


////Extention metotlar
//string ifade = "Emre Pirvan";

//bool sonuc = ifade.CheckSpaces();
//Console.WriteLine(sonuc);

//Console.WriteLine(ifade.RemoveWhiteSpaces().MakeUpperCase());

//Console.WriteLine(ifade.RemoveWhiteSpaces().MakeLowerCase());

//int[] dizi = { 2, 6, 5, 9, 8, 10, 3 };
//dizi.SortArray().EkranaYazdir();

//int sayi = 5;
//sayi.IsEvenNumber().EkranaYazdir();
//sayi.EkranaYazdir();

//Console.WriteLine(ifade.GetFirtsCharacter());



//Console.WriteLine("-------------------------------------------");

//RecursiveMethods deneme = new();
//deneme.Faktoriyel(5).EkranaYazdir();
