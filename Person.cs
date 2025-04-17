using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37_4
{
    internal class Person : ISpeak1, ISpeak2
    {
        public void Say1(string s)
        {
            Console.WriteLine("Говорит громко - " + s);
        }

        public void Think(string s)
        {
            Console.WriteLine("Думает - " + s);
        }

        public void Say3(string s)
        {
            Console.WriteLine("Говорит нормально - " + s);
        }
    }
}
