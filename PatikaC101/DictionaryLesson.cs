using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101
{
    public class DictionaryLesson
    {
        public static void Alistirmalar()
        {
            Dictionary<int, string> kullanıcılar = new Dictionary<int, string>();
            kullanıcılar.Add(10, "ayse Yılmaz");
            kullanıcılar.Add(12, "ali çetin");
            kullanıcılar.Add(18, "veli tezgin");
            kullanıcılar.Add(20, "Özcan deniz");

            //Dizinin elemanlarına erişim
            Console.WriteLine("----------elemanlarına erişim--------");
            Console.WriteLine(kullanıcılar[12]);
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }
            //Count
            Console.WriteLine("----------Count--------");

            Console.WriteLine("Count " + kullanıcılar.Count());

            //Contains
            Console.WriteLine("----------Contains--------");
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("ayse Yılmaz"));


            //Remove
            Console.WriteLine("----------Remove--------");
            kullanıcılar.Remove(12);
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine("values " + item.Value); //Sadece isimleri yazdırıcak
            }
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine("Keys " +item.Key); //Sadece keyler yazdırıcak
            }

        }
    }
}
