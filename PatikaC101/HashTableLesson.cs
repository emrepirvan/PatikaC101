using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PatikaC101
{
    public static class HashTableLesson
    {
        public static void Alistirma()
        {
            Hashtable aracPlaka = new Hashtable();

            aracPlaka.Add("16 uı 24", "Bmw");
            aracPlaka.Add("11 ep 435", "Mercedes");
            aracPlaka.Add("41 zp 856", "Lada");

            foreach (var item in aracPlaka.Keys)
            {
                Console.WriteLine(item + "- " + aracPlaka[item]);
            }

        }
    }
}
