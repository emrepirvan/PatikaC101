using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101
{
    public class RecursiveMethods
    {
        public int Expo(int sayi, int us)
        {
            if (us < 2)
            {
                return sayi;
            }
            return Expo(sayi, us - 1) * sayi;
        }
        // Expo(3,4)
        // Expo(3,3)*3;
        // Expo(3,2)*9;
        // Expo(3,1)*81;
        // 3*3*3*3 = 3^4;

        public int Faktoriyel(int sayi)
        {
            if (sayi==1)
            {
                return sayi;
            }
            return Faktoriyel(sayi - 1) * sayi;
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


//RecursiveMethods deneme = new();
//deneme.Faktoriyel(5).EkranaYazdir();
