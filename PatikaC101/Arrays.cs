using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101
{
    public class Arrays
    {
        public static void Array1()
        {
            //array definition
            string[] colors = new string[5];

            string[] animals = { "cat", "dog", "mouse" };

            int[] array;
            array = new int[5];

            //giving values and accessing the arrays.
            colors[0] = "blue";
            array[3] = 10;

            Console.WriteLine(animals[1]);
            Console.WriteLine(array[3]);
            Console.WriteLine(colors[0]);

            //Using array with loops

            //taking numbers from console and add in the array, and later calculate numbers of the average

            Console.Write("Please input length of the array : ");
            int arraylength = int.Parse(Console.ReadLine());
            int[] numbArray = new int[arraylength];

            for (int i = 0; i < numbArray.Length; i++)
            {
                Console.Write("please enter the {0}st number : ", i + 1);
                numbArray[i] = int.Parse(Console.ReadLine());
            }
            int total = 0;
            foreach (int i in numbArray)
            {
                total += i;
            }
            Console.WriteLine("average of numbers : {0}", total / arraylength);
        }
    }
}
