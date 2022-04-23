using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101
{
//Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın.
//(ArrayList sınıfını kullanara yazınız.)
//Negatif ve numeric olmayan girişleri engelleyin.
//Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
//Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
    public static class Collections_Quesrion_1
    {
        public static void Cozum()
        {
            List<int> AkeyNums = new List<int>() {};
            List<int> NkeyNums = new List<int>() { };
            for (int i = 0; i < 20;)
            {
                string ssayi = Console.ReadLine();
                int sayi;
                if (int.TryParse(ssayi,out sayi) && sayi > 0)
                {
                    sayi = Convert.ToInt32(ssayi);
                        for (int j = 2; j < sayi; j++)
                        {if (sayi % j == 0)
                        {
                            NkeyNums.Add(sayi);
                            break;
                        }
                        else
                        {
                            AkeyNums.Add(sayi);
                            break;
                        }
                        }
                        i++;
                }
                else
                    Console.WriteLine("integer ve sıfırdan büyük bir sayi giriniz");
            }
            NkeyNums.Sort();
            AkeyNums.Sort();
            Console.WriteLine("---------Asal olmayan sayilar------------");
            int NTop = 0;
            foreach (var item in NkeyNums)
            {
                NTop += item;
                Console.WriteLine(item);
            }
            Console.WriteLine("------------Asal sayilar---------");
            int ATop = 0;
            foreach (var item in AkeyNums)
            {
                ATop += item;
                Console.WriteLine(item);
            }
            Console.WriteLine("------------Total and count---------");
            Console.WriteLine($" asal olmayanların sayisi : {NkeyNums.Count} ,  Elemanlari ortalaması : {NTop/ NkeyNums.Count }");
            Console.WriteLine($" asal olanların sayisi : {AkeyNums.Count} ,  Elemalari ortalaması : {ATop/ AkeyNums.Count }");
           
        }
        
    }
}
