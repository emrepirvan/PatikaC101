using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101
{
     public class StructLesson
    {
        public static void Cozum()
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KısaKenar = 3;
            dikdortgen.UzunKenar = 4;

            Console.WriteLine("Class Alan Hesabı : {0}", dikdortgen.AlanHesap());

            //Dikdortgen_struct dikdortgen_Struct = new Dikdortgen_struct();
            Dikdortgen_struct dikdortgen_Struct; // New le yapmadanda kullanabilirsin
            dikdortgen_Struct.KısaKenar = 5;
            dikdortgen_Struct.UzunKenar = 6;
            Dikdortgen_struct dikdortgen_Struct1 = new Dikdortgen_struct(3,5);
            Console.WriteLine("Class Alan Hesabı : {0}", dikdortgen_Struct.AlanHesap());
            Console.WriteLine("Class Alan Hesabı : {0}", dikdortgen_Struct1.AlanHesap());
        }
        class Dikdortgen  //adı stack'te tutulur, verileri ise Heaptedir. Heap'teki verilerin bulunduğu adresi işaret eder
        {
            public int KısaKenar, UzunKenar;
            public long AlanHesap()
            {
                return this.KısaKenar * this.UzunKenar;
            }
            public Dikdortgen()
            {
                KısaKenar = 3;
                UzunKenar = 4;
            }

        }
        struct Dikdortgen_struct  //Belleğin stack bölgesinde tutulur
        {
            public Dikdortgen_struct(int kisa, int uzun)
            {
                this.KısaKenar = kisa;
                this.UzunKenar = uzun;
            }

            public int KısaKenar, UzunKenar;
            public long AlanHesap()
            {
                return this.KısaKenar * this.UzunKenar;
            }
        }
    }
}
///Peki neden struc kullanmalıyım; Sınıflar Büyük verili yapılarda Kullanılması uygun
///stuct ise 16byte 'dan küçük veriler için struct kullanılması daha avantajlı olur
