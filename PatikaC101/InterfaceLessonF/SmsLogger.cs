using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101.InterfaceLessonF
{
    public class SmsLogger : Ilogger
    {
        public void WriteLog() //Gövdesi boş bırakılabilir
        {
            // throw new NotImplementedException();
            Console.WriteLine("Sms olarak log yazar");
        }
    }
}
