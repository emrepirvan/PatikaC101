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
        public static void ArrayMethods()
        {
            //Array methods

            //Sort   (sıralama)
            int[] numbers = { 5, 40, 43, 12, 65, 23, 54 };
            Console.WriteLine("**Unsorted numbers Array**");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*Sorted numbers Array*");
            Array.Sort(numbers);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            //------------------------------------------------
            //CLEAR
            //Clear Verdiğimiz bir indexten başlayarak verdiğimiz eleman sayısı kadarını sıfırlıyor.

            Console.WriteLine("****CLEAR*****");
            Array.Clear(numbers, 2, 3);
            foreach (var item in numbers)   // ikinciden başlayarak 3 adet elamanı sıfırladık.
            { Console.WriteLine(item); }

            //------------------------------------------------

            //REVERSE
            // diziyi aynalıyor. sıralaması ters dönüyor
            Console.WriteLine("****REVERSE*****");
            Array.Reverse(numbers);
            foreach (var item in numbers)   // sıralamayı tersine çevirdik
            { Console.WriteLine(item); }

            //------------------------------------------------
            // verdiğiniz elemanın indexini döner, yani bulundugu yeri
            //IndexOf

            Console.WriteLine("****INDEXOF*****");
            Console.WriteLine(Array.IndexOf(numbers, 12));   /// 12 nin index'ini verdi.

            //------------------------------------------------
            //RESIZE 
            Console.WriteLine("****RESIZE*****");
            Array.Resize<int>(ref numbers, 9);  // 7 elemanlı dizimiz vardı 9 elemana çıkardık
            numbers[8] = 99;            //8. indexteki elemana 99 atadık
            foreach (var item in numbers)
            { Console.WriteLine(item); }
        }
    }
}
