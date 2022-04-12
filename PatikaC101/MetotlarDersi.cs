using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101
{
    public class MetotlarDersi
    {
        //erişim_belirteci geri_dönüştipi metot_adi(parametrelerListesi/arguman)
        ///(
        ///Komutlar:
        ///)
        public int Topla(int deger1, int deger2)
        {
            return deger1 + deger2;
        }
        //Fonksiyon içerisinde parametre üzerinde değişiklik yapıldığında ana değişken değişmez. Sadece kopyası üzerinde değişiklik yapılmış olur. 

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        /// <summary>
        /// doğrudan 2 int degerinin ref degerleri üzerinde arttırıp toplama
        /// </summary>
        /// <param name="deger1"></param>
        /// <param name="deger2"></param>
        /// <returns>toplam</returns>
        public int ArttırVeTopla(ref int deger1,ref int deger2)
        /// bu şekilde sadece fonksiyon içinde değil de doğrudan o değişkenler üzerinde işlem yapmış oluyoruz
        {
            deger1++;
            deger2++;
            return deger1 + deger2;
        }
    }
}
