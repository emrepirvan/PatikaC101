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
        public static void TelRehber()
        {
            int n = int .Parse(Console.ReadLine());
            Dictionary<string, string> phoneNum = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] eleman = Console.ReadLine().Split(' ');
                string name = eleman[0];
                string phone = eleman[1];

                phoneNum.Add(name, phone);
            }
            string searchName = "";
            while ((searchName = Console.ReadLine()) != null)
            {
                if (phoneNum.ContainsKey(searchName))
                {
                    Console.WriteLine(searchName + "=" + phoneNum[searchName]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }

        }
    }
}
