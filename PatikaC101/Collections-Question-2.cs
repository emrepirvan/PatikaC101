using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101
{
    public class Collections_Question_2
    {
        public static void Cozum()
        {
            int[] keyNums = new int[7];
            for (int i = 0; i < 7;)
            {
                string ssayi = Console.ReadLine();
                int sayi;
                if (int.TryParse(ssayi, out sayi))
                {
                    keyNums[i] = sayi;
                    i++;
                }
                else
                    Console.WriteLine("integer ve sıfırdan büyük bir sayi giriniz");
            }
            Array.Sort(keyNums); 
            int[] enKucukUc = new int[3];
            int[] enBuyukUc = new int[3];
            for (int i = 0; i < 3; i++)
                enKucukUc[i] = keyNums[i];
            Console.WriteLine("KLAVYEDEN ALINAN DEGERLER");
            foreach (int i in keyNums)
                Console.Write($" {i} ");
            Console.WriteLine("\nEn Kucuk 3 sayi");
            foreach (var item in enKucukUc)
                Console.WriteLine(item);
            Console.WriteLine("\nEn Buyuk 3 sayi");
            Array.Reverse(keyNums);
            for (int i = 0; i < 3; i++)
                enBuyukUc[i] = keyNums[i];
            foreach (var item in enBuyukUc)
                Console.WriteLine(item);
            int topKucuk = 0;
            int topBuyuk = 0;
            for (int i = 0; i < enBuyukUc.Length; i++)
            {
                topBuyuk += enBuyukUc[i];
            }
            for (int i = 0; i < enKucukUc.Length; i++)
            {
                topKucuk += enKucukUc[i];
            }
            Console.WriteLine($"EN KUCUK SAYİLARİN TOPLAMİ {topKucuk} \n En BUYUK SAYİLARİN TOPLAMİ {topBuyuk}" +
                $"\n En kucuk sayilarin ortalamasi {topKucuk/3} En buyuk sayilarin ortalamasi {topBuyuk/3}" +
                $" \n en buyuk ve en kucuk sayilarin ortalamalari toplami {(topKucuk / 3) + (topBuyuk/3)}");
        }
    }
}
