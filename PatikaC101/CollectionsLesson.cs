using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101
{
    internal class CollectionsLesson
    {
        public static void Alistirmalar()
        {

            //List<T> class
            //System.Collections.Generic
            // T-> object türündedir. 

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(12);
            sayiListesi.Add(17);
            sayiListesi.Add(29);
            sayiListesi.Add(4);
            sayiListesi.Add(35);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Sari");
            renkListesi.Add("yesil");
            renkListesi.Add("turuncu");

            //Count

            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);



            //Foreach ve listforeach ile elemanlara erişim
            foreach (var item in renkListesi)
                Console.WriteLine(item);
            foreach (var item in sayiListesi)
                Console.WriteLine(item);
            Console.WriteLine("//-----------------------------------------------------------------------");

            renkListesi.ForEach(renk => Console.WriteLine(renk));
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            //
            //Listeden nasıl eleman çıkarabiliriz
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(0);
            Console.WriteLine("//-----------------------------------------------------------------------");
            sayiListesi.Remove(35);
            renkListesi.Remove("turuncu");
            //-----------------------------------------------------------------------
            renkListesi.ForEach(renk => Console.WriteLine(renk));
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));

            Console.WriteLine("//-------------Liste içerisinde arama--------------------------");
            if (sayiListesi.Contains(4))
                Console.WriteLine("4 var");


            Console.WriteLine("//-------------------------------Eleman ile index'e erişme--------------------------");

            Console.WriteLine(renkListesi.BinarySearch("yesi"));


            Console.WriteLine("//-------------------------Diziyi list'e çevirme------------------------------------");

            string[] hayvanlar = { "kurt", "tilki", "aslan", "kedi" };

            List<string> hayvanlarListesi = new List<string>(hayvanlar);
            hayvanlarListesi.ForEach((hayvan) => Console.WriteLine(hayvan));
            hayvanlarListesi.Clear();
            Console.WriteLine("//-------------------------Liste temizlendi------------------------------------");

            hayvanlarListesi.ForEach((hayvan) => Console.WriteLine(hayvan));

            Console.WriteLine("//-------------------------Liste içerisinde nesne tutmak------------------------------------");

            List<Kullanıcılar> KullanıcıListesi = new List<Kullanıcılar>();

            Kullanıcılar kullanıcı1 = new Kullanıcılar() { Isim = "EMRE", Soyisim = "Pirvan", Yas = 26 };
            Kullanıcılar kullanıcı2 = new Kullanıcılar() { Isim = "Demir", Soyisim = "Çelik", Yas = 21 };

            KullanıcıListesi.Add(kullanıcı1);
            KullanıcıListesi.Add(kullanıcı2);
            KullanıcıListesi.ForEach((kullanıcı) => Console.WriteLine(kullanıcı.Isim));
            KullanıcıListesi.ForEach((kullanıcı) => Console.WriteLine(kullanıcı.Soyisim));
            KullanıcıListesi.ForEach((kullanıcı) => Console.WriteLine(kullanıcı.Yas));

            foreach (var kullanıcı in KullanıcıListesi)
            {
                Console.WriteLine(kullanıcı.Isim);
                Console.WriteLine(kullanıcı.Soyisim);
                Console.WriteLine(kullanıcı.Yas);
                Console.WriteLine("");
            }
        }
        public class Kullanıcılar
        {
            private string _isim;

            public string Isim
            {
                get { return _isim; }
                set { _isim = value; }
            }
            private string _soyisim;

            public string Soyisim
            {
                get { return _soyisim; }
                set { _soyisim = value; }
            }
            private int _yas;

            public int Yas
            {
                get { return _yas; }
                set { _yas = value; }
            }
        } 
    }
}
