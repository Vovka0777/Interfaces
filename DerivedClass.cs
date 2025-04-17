using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37_3
{
    internal class DerivedClass : IInterface3
    {
        public void Method1()
        {
            Console.Write("Метод Method1");
        }
        public void Method2()
        {
            Console.Write("Метод Method2");
        }
        public void Method3()
        {
            Console.Write("Метод Method3");
        }
    }
}
