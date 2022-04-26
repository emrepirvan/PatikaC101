using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101.InterfaceLessonF
{
    public class FileLogger : Ilogger //İMPLEMENTE ETMEK GEREKİYOR
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Dosya'ya log yazar");
        }
    }
}
