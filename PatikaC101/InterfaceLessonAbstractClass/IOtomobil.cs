using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101.InterfaceLessonExample
{
    public interface IOtomobil
    {
        public int KacTekerlektenOlusur();
        public string HangiMarkaninAraci();
        public string StardantRengiNe();

    }
}
///Şartlar
///Modeli belli olan 3 otomobil classı yaratılacak 
///bu otomobillerin markasının ne olduğunu bana döndüren
///Otomobillerin standart renginin ne olduğu
///kaç tekerlekten oluştuğunu döndüren
///bunları bir interface üzerinde bileştirip bu interfaceden kalıtım aldır.
