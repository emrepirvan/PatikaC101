using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101
{
    public class SwitchCase
    {
        public static void example()
        {
            int month = DateTime.Now.Month;


            //Expression
            switch (month)
            {
                case 1:
                    Console.WriteLine("ocak ayındasınız");
                    break;
                case 2:
                    Console.WriteLine("subat ayındasınız");
                    break;
                case 3:
                    Console.WriteLine("mart ayındasınız");
                    break;
                case 4:
                    Console.WriteLine("nisan ayındasınız");
                    break;
                case 5:
                    Console.WriteLine("mayıs ayındasınız");
                    break;
                default:
                    Console.WriteLine("Yanlış veri girişi");
                    break;
            }
            switch (month)
            {
                case 12:
                case 2:
                case 1:
                    Console.WriteLine("kış ayındasınız");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlk bahar ayındasınız");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz ayındasınız");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Son bahar ayındasınız");
                    break;
                default:
                    break;
            }
        }
    }
}
