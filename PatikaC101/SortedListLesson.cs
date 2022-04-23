using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101
{
    public static class SortedListLesson
    {
        public static void Alistirma()
        {
            SortedList DersAKTS = new SortedList();
            DersAKTS.Add(5, "Makina elemanları");
            DersAKTS.Add(3, "Isı transferi");
            DersAKTS.Add(2, "İş sağlığı güvenliği");
            DersAKTS.Add(6, "Mühendislik malzemeleri");

            for (int x = 0; x < DersAKTS.Count; x++)
            {
                Console.WriteLine("{0} and {1}",
                            DersAKTS.GetKey(x),
                    DersAKTS.GetByIndex(x));
            }
            Console.WriteLine("-----------------------------------------");
            foreach (DictionaryEntry pair in DersAKTS)
            {
                Console.WriteLine("{0} and {1}",
                        pair.Key, pair.Value);
            }

        }
    }
}
