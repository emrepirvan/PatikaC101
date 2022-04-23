using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101
{
    public static class Collections_Question_3
    {
        public static void Cozum1()
        {
            string sesliharf = "";
            string cumle = Console.ReadLine().ToString();
            for (int i = 0; i < cumle.Length; i++)
            {
                if (cumle[i] == 'a' || cumle[i] == 'e' || cumle[i] == 'ı'|| cumle[i] == 'i'
                    || cumle[i] == 'o' || cumle[i] == 'ö' || cumle[i] == 'u' || cumle[i] == 'ü' )
                {
                    sesliharf += cumle[i];
                }
            }
            
            Console.WriteLine(sesliharf);
        }
        public static void Cozum2()
        {
            string sesliharf1 = "";
            string cumle2 = Console.ReadLine().ToString();
            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'u', 'ü', 'ö' };
            for (int i = 0; i < cumle2.Length; i++)
            {
                for (int j = 0; j < sesliHarfler.Length; j++)
                {
                    if (cumle2[i] == sesliHarfler[j])
                    {
                        sesliharf1 += cumle2[i];
                    }
                }
            }
            Console.WriteLine(sesliharf1);

        }
    }
}
