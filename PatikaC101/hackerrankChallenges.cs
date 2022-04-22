using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101
{
    public class hackerrankChallenges
    {
        public static void PlusMinus()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            
            decimal neg = 0;
            decimal poz = 0;
            decimal zero = 0;
            decimal length = arr.Count;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    neg++;
                }
                else if (arr[i] > 0)
                {
                    poz++;
                }
                else
                {
                    zero++;
                }

            }

            neg = Decimal.Round(neg / length, 6);
            poz = Decimal.Round(poz / length, 6);
            zero = Decimal.Round(zero / length, 6);

            Console.WriteLine(neg + "  " + poz + "  " + zero);
        }
        public static string hesaplama(int n, int p)
        {
            if (n < 0 || p < 0)
            {
                return "n and p should be non-negative";
            }
            return "n and p should be non-negative";
        }
    }
}
