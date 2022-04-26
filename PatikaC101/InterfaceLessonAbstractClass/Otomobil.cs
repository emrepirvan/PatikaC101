using PatikaC101.InterfaceLessonExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101.InterfaceLessonAbstractClass
{
    public abstract class Otomobil
    {
        public int  KacTekerlektenOlusur()
        {
            return 4;
        }
        public virtual Renk StandartRengiNe()
        {
            return Renk.Mavi;
        }
        public abstract Marka HangiMarkaninAraci();


    }
}
