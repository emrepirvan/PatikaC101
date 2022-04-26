using PatikaC101.InterfaceLessonAbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaC101.InterfaceLessonExample
{
    public static class Example
    {
        public static void Cozum()
        {
            Corolla corolla = new Corolla();
            Getz getz = new Getz();
            Focus focus = new Focus();
            Civic civic = new Civic();
            Console.WriteLine(civic.ToString());
            Console.WriteLine(focus.ToString());
            Console.WriteLine(getz.ToString());
            Console.WriteLine(corolla.ToString());
            Console.WriteLine("------------------Abstract Classlarla Oluşturulanlar-----------------------------");
            NewFocus focus1 = new NewFocus();
            Console.WriteLine( focus1.ToString());
            NewGetz getz2 = new NewGetz();
            Console.WriteLine(getz2.ToString());
            NewCorolla corolla1 = new();
            Console.WriteLine(corolla1.ToString());
            
        }
    }
}
/// Abstract classlar' sadece kalıtım için kullanılan sınıflar denilebilir
/// virtual metotlarin ve interface'lerin birleşimi gibi düşünebiliriz
/// Normal sınıflar gibi new anahtar kelimesiyle üretilemezler . yani nesneleri oluşturulamaz
/// interfaceler ve abstractlar tek başlarına anlamları olan yapılar değiller mutlaka bir sınıf üzerinden türetilmeleri gerekir
/// interfaceler gibi metot bildirimi yapabilirsin
/// Abstract metotlar override edilebilir
/// Mutlaka türetilen alt sınıflar ilgili abstract metodu kendilerine implemente etmek zorundalar / Gövdesini yazmak zorundalar
/// bir sınıf saddece tek bir abstract sınıftan örnek alabilir
/// abstact sınıf başka bir abstract sınıftan kalıtım alabilir 
/// abstracttan kalıtım almış bir abstractı başka bir sınıfa eklemiş olduğumuzda bir sınıf birden fazla abstractan miras almış gibi olabilir
/// 