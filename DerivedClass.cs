using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    internal class DerivedClass : IInterface
    {
        public void Method()
        {
            Console.Write("Привет!");
        }
    }
}
