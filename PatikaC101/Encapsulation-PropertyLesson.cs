using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101
{
    public class Encapsulation_PropertyLesson
    {
        public static void Calisma()
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Isim = "Leyal";
            ogrenci1.Soyisim = "Demirci";
            ogrenci1.OgrenciNo = 2312;
            ogrenci1.Sinif = 1;
            ogrenci1.OgrenciBilgileri();
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileri();
        }

        class Ogrenci
        {
            private string _isim, _soyisim;
            private int _ogrenciNo, _sinif;

            public string Isim
            {
                get { return _isim; }
                set { _isim = value; }
            }
            public string Soyisim
            {
                get { return _soyisim; }
                set { _soyisim = value; }
            }
            public int OgrenciNo
            {
                get { return _ogrenciNo; }
                set { _ogrenciNo = value; }
            }
            //şartı neden meto içinde değilde burda tanımladık?
            //Çünkü başka metotlarda tanımlayabilirdik her metodun içine bunu yazamayız
            //veya hatalı değer atama gibi durumlar da olabilirdi
            //Dolayısıyla biz önlemi en baştan almış olduk
            public int Sinif 
            {
                get { return _sinif; }
                set 
                {
                    if (value < 1)
                    {
                        Console.WriteLine("SİNİF EN AZ 1 OLABİLİR");
                        _sinif = 1;
                    }
                    else if (value >= 1)
                    {
                        _sinif = value;
                    }
                }
            }
            public Ogrenci()
            {

            }
            public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
            {
                Isim = isim;
                Soyisim = soyisim;
                OgrenciNo = ogrenciNo;
                Sinif = sinif;
            }
            public void OgrenciBilgileri()
            {
                Console.WriteLine("------Ogrenci bilgileri------");
                Console.WriteLine($" Ogrenci adi :  {Isim}");
                Console.WriteLine($" Ogrenci Soyadi :  {Soyisim}");
                Console.WriteLine($" Ogrenci No  :  {OgrenciNo}");
                Console.WriteLine($" Ogrenci Sinifi  {Sinif}");
            }
            public void SinifAtlat()
            {
                Sinif += 1;
            }
            public void SinifDusur() //Propertyi burada kullan  _sinif'i DEGİL!!!!!!
            {
                this.Sinif = this.Sinif - 1;
            }
        }
    }
}
