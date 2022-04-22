using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace PatikaC101
{
    public class ArrayListLesson
    {
        public static void Alistirma()
        {
            ArrayList liste = new ArrayList();
            //{
            //    "ayşe",2,'A',true
            //};
            //liste.Add(23);

            // İçerisindeki elemanlara erişme
            //Console.WriteLine(liste[1]+"\n");
            foreach(var i in liste) 
                Console.WriteLine(i);

            //AddRange
            Console.WriteLine("****Add range ****");
         //   string[] renkler = { "kirmizi", "sari", "mavi" };
          //  liste.AddRange(renkler);
            List<int> sayilar = new List<int>() { 1, 39, 56, 32, 48 };
            //liste.AddRange(sayilar);
            liste.AddRange(sayilar);
            foreach (var i in liste)
                Console.WriteLine(i);

            //Sort
            Console.WriteLine("****Sorting****");
            liste.Sort();
            foreach (var i in liste)
                Console.WriteLine(i);
            //Binary search
            Console.WriteLine("****Sorting****");
           Console.WriteLine(    liste.BinarySearch(39));
            Console.WriteLine("****reverse****");
            liste.Reverse();
            foreach (var i in liste)
                Console.WriteLine(i);
            Console.WriteLine("****Clear****");
            liste.Clear();

            foreach (var i in liste)
                Console.WriteLine(i);
        }
    }
}