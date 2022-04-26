using PatikaC101.InterfaceLessonExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101.InterfaceLessonAbstractClass
{
    internal class NewCivic : Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Honda;
        }
        public override Renk StandartRengiNe()
        {
            return Renk.Kırmızı;
        }
        public override string ToString()
        {
            return $"Hangi Markanin araci   : {HangiMarkaninAraci()} \nKac tekerlekten oluşur : {KacTekerlektenOlusur()} \nStandart Rengi ne     : {StandartRengiNe()} \n";
        }
    }
}
