using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101
{
    public class LoopsWhileForeach
    {
        public static void WhileFoeach()
        {
            //While
            // calculate the average of the numbers starting from 1 to the number entered from the screen and prints it to the console.
            int numb = int.Parse(Console.ReadLine());
            int counter = 1;
            int total = 0;
            while (counter <= numb)
            {
                total += counter;
                counter++;
            }
            int avg = total / numb;
            Console.WriteLine("{0}/{1} = {2}", total, numb, avg);

            // print characters a to z .
            char character = 'a';
            while (character <= 'z')
            {
                Console.Write(" {0} ", character);
                character++;
            }
            //Foreach
            Console.WriteLine("------------------  foreach ----------------");

            string[] cars = { "bmw", "toyota", "fiat", "hyundai" };
            Console.Write("Cars : ");
            foreach (var item in cars)
            {
                Console.Write(" {0} ", item);
            }

        }
    }
}
