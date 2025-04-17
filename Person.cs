using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37_4
{
    internal class Person : ISpeak1, ISpeak2
    {
        public void Say1()
        {
            Console.WriteLine("Говорит громко - Я люблю программирование!");
        }

        public void Think()
        {
            Console.WriteLine("Думает - А C# больше всего");
        }

        public void Say3()
        {
            Console.WriteLine("Говорит нормально - Меньше люблю компьютерные игры");
        }
    }
}
