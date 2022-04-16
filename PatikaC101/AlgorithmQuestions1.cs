using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101
{
    public static class AlgorithmQuestions1
    {
        public static void SeparateEvenNumbers1 ()
        {   Console.WriteLine("Please Input n");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("please enter the {0}st number : ", i + 1);
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (dizi[i] % 2 == 0)
                {
                    Console.Write(" {0} ", dizi[i]);
                }
            }
        }
        public static void NumbersDivisibleByM()
        {
            Console.WriteLine("PLEASE INPUT N VALUE");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("PLEASE INPUT M VALUE");
            int m = int.Parse(Console.ReadLine());
            int[] dizi = new int[n];
            Console.WriteLine("PLEASE INPUT {0} NUMBERS", n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("please enter the {0}st number : ", i + 1);
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (dizi[i] % m == 0)
                {
                    Console.Write(" {0} ", dizi[i]);
                }
            }
        }
        public static void InputStrings()
        {
            Console.WriteLine("PLEASE INPUT N VALUE");
            int n = int.Parse(Console.ReadLine());
            string[] dizi = new string[n];
            Console.WriteLine("PLEASE INPUT {0} WORD", n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("please enter the {0}st word : ", i + 1);
                dizi[i] = Console.ReadLine();
            }

            for (int i = dizi.Length -1; i >= 0 ; i--)
            {
                 Console.Write(" {0} ", dizi[i]);
            }
        }
        public static void CountingWords( )
        {

            Console.WriteLine("Bir cumle giriniz");
            string cumle = Console.ReadLine();
            string[] dizi = cumle.Split(' ');
            int harf = 0;
            Console.WriteLine(" dizi uzunluğu  " + dizi.Length);
            for (int i = 0; i < dizi.Length; i++)
            {
                harf += dizi[i].Length;
            }
            Console.WriteLine(harf);
        }
    }
}
