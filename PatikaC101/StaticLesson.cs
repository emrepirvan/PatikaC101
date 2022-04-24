using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// bir sınıf içerisindeki static olmayan Field'lara metotlara property'lere
/// o sınıftan oluşurduğumuz nesne aracılığıyla erişiyoruz.
/// 
/// Static olanlara ise o sınıfın adıyla erişiyoruz. Nesne oluşturumazsın
/// 
/// OSsınıfınAdı.(Erişmek istediğiniz metot ya da property)
/// 
/// 

namespace PatikaC101
{
    public class StaticLesson
    {
        public static void Ders()
        {
            Console.WriteLine($"Calisan sayisi {Calisan1.CalisanSayisi}");
            Calisan1 yeni = new Calisan1("emre","Pirvan","Mühendislik");
            Calisan1 yeni1 = new Calisan1("Ahmet", "Mehmet", "Planlama");
            Calisan1 yeni2 = new Calisan1("Ayse", "gönül", "İK");
            Calisan1 yeni3 = new Calisan1("ali", "erkin", "Bakım");
            Console.WriteLine($"Calisan sayisi {Calisan1.CalisanSayisi}");
        }
    }
    //Static olmayan Normal bir Class için Static olmayan elemanlar o sınıf içerisinde nesneye özgüyken
    //onun içindeki static olmayan üyeler o sınıfın nesnelerine özel set'leniyor ve getiriliyorken;
    //
    //Bir sınıf içerisinde static olan üyeler sınıf bazında atanır
    //Yani bu calisanSayisi sınıfa ait bir özellik;
    //Her yerden bunu değiştirebilirsiniz ve heryerden ne kadar nesne oluşturursanız oluşturun
    //Siz buna sınıf aracılığıyla ulaşabileceğiniz için
    // Her zaman değiştirilen en son değeri getiricektir.
    class Calisan1 
    {
        private static int _calisanSayisi;

        

        public static int CalisanSayisi { get => _calisanSayisi;   /*set => _calisanSayisi = value;*/}

        private string Isim; //Bunlarin propertylerini yaratmadık çünkü sınıf dışından erişilmesini istemiyorm
        private string Soyisim; //Sadece kurucu aracılığıyla ismi soyismi set etmek istiyorum
        private string Departman;//ve dışarıdan da get etmeyeceğim sadece kurucusunda erişilebilir fieldlar yaratıyoruz
        public Calisan1(string isim,string soyisim, string departman)
        {
            this.Isim = isim; //Nesnesi yaratılırken bu fieldlari setlemiş oldum
            this.Soyisim = soyisim;
            this.Departman = departman;
            _calisanSayisi++; //private olan calisan sayisini biz şirkete her eleman eklediğimizde arttırmış olduk
        } //Dolayısıyla Biz public olan CalisanSayisina erişmek istediğimizde arttırılmıs private _calisanSayisi geri dönücek
        //Peki ben static contructor yaratırsam; static const'ların erişim belirteçleri yoktur
        static Calisan1() { 
            _calisanSayisi= 0; 
        }
    }
}
