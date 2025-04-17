using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Console.WriteLine(myClass.Pi());
            Console.WriteLine(myClass.Num());
            Console.WriteLine(myClass.Sqr());
            Console.WriteLine(myClass.Sqrt());
            Console.Read();
        }
    }
}
