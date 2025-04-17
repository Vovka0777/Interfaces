using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Say1("Я люблю программирование!");
            person.Think("А C# больше всего");
            person.Say3("Меньше люблю компьютерные игры");
            Console.ReadKey();
        }
    }
}
