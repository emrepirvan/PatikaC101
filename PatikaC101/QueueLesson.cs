using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101
{
    public static class QueueLesson
    {
        public static void Alistirma()
        {
            Queue<string> Kece = new Queue<string>();

            Kece.Enqueue("Ford");
            Kece.Enqueue("renault");
            Kece.Enqueue("Alçak kabin tavan ön");

            string alinankece = Kece.Dequeue(); // Bir elemanı atadı , atanan eleman Listeye ilk giren elemandır
            //FiFo'ya uygun bir şekilde işliyor

            foreach (var item in Kece)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("alinan kece  " +alinankece);  //Ford  
        }
    }
}
