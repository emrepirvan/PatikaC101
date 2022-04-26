using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101
{
    public class EnumLesson
    {
        public static void Cozum()
        {
            Console.WriteLine(Gunler.Pazar); // String formatında geliyor
            Console.WriteLine((int)Gunler.Pazar); //indexini getirir

            int sıcaklık = 19;
            if (sıcaklık <= (int)HavaDurumu.normal)
                Console.WriteLine("Hava durumu dışarısıya çıkmak için yeterince iyi değil");
            else if (sıcaklık >= (int)HavaDurumu.sıcak)
                Console.WriteLine("dışarıya çıkmak için çok sıcak bir gün");
            else if (sıcaklık <= (int)HavaDurumu.sıcak && sıcaklık >=(int)HavaDurumu.normal)
            {
                Console.WriteLine("Dışarıya çıkmak için mükemmel bir hava");
            }
            
        }
        enum Gunler
        {
            Pazartesi, //burda enum'ın bu elemanının adını belirliyoruz ve index'si 0;
            Sali,
            Carsamba,
            Persembe =13,
            Cuma,
            Cumartesi,
            Pazar
        }
        enum HavaDurumu
        {
            soguk=5,
            normal=20,
            sıcak=25,
            cokSıcak =30
        }
    }
    public static class sınıf
    {

    }
}
