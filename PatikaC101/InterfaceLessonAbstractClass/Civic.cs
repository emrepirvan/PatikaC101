using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101.InterfaceLessonExample
{
    internal class Civic : IOtomobil
    {
        public string HangiMarkaninAraci()
        {
            return Marka.Honda.ToString();
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }
        public override string ToString()
        {
            return $"Hangi Markanin araci   : {HangiMarkaninAraci()} \nKac tekerlekten oluşur : {KacTekerlektenOlusur()} \nStandart Rengi ne     : {StardantRengiNe()} \n";
        }

        public string StardantRengiNe()
        {
           return Renk.Mavi.ToString();
        }
    }
}
