using PatikaC101.InterfaceLessonF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//interface içersindeki property'lere ilk deger ataması yapılmaz
//Metotların gövdesi de yazılmaz
//Sadece implamente eden sınıfın ne iş yaptığının bir arayüzü olarak düşünebiliriz.
//Interface'lere neden ihtiyaç duyarız ?
//interfaceden kalıtım alan sınıfın sorumluluğunun yani çerçevesinin çizilmesine yardımcı olur şeklinde düşünebiliriz
//
//Aynı sorumluluğu başka bir şekilde yapması gerekenn başka bir sınıf söz konusu olduğunda
//o implemente o interface'den kalıtım alarak aynı işi kendi tarzında yapabilir
//Buna olanak sağlar interface'ler
namespace PatikaC101
{//Gerçek hayatta'da en çok kullandığımız yerler database işlemleri için veya loglama işlemleri için interface yaratmak
    public static class InterfaceLesson
    {
        public static void Cozum()
        {
            FileLogger fileLogger = new FileLogger();
            fileLogger.WriteLog();
            DatabaseLogger databaseLogger = new DatabaseLogger();  
            databaseLogger.WriteLog();
            SmsLogger smsLogger = new SmsLogger();
            smsLogger.WriteLog();

            LogManager logManager = new LogManager(new FileLogger());
            logManager.WriteLog();
        }
    }

}
