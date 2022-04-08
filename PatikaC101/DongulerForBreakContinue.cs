using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101
{
    public class DongulerForBreakContinue
    {
        public static void dongu() { 
                    // It prints the odd numbers from the screen to the entered number to the screen.
            Console.WriteLine("Lütfen bir sayi giriniz :  ");
            int counter = int.Parse(Console.ReadLine());
            Console.WriteLine("odd numbers");
            for (int i = 1; i < counter; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write("{0}  ",i);
                }
            }

            // Sum of 1 to 1000 odd and even numbers.
            Console.WriteLine("");
            Console.WriteLine("sum of odd and even numbers");

            int sumOdd = 0;
            int sumEven = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2==0)
                {
                    sumEven += i;
                }

                if (i % 2==1)
                {
                    sumOdd += i;
                }
            }
            Console.WriteLine("Sum of even numbers 1 to 1000 : {0}",sumEven);
            Console.WriteLine("Sum of odd numbers 1 to 1000 : {0}", sumOdd);

            //Break, continue

            for (int i = 1; i < 10; i++)
            {
                if (i==4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

    }
}
