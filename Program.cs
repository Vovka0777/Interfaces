using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TVSet tv = new TVSet();
            tv.On();
            tv.Off();
            Console.WriteLine();
            PersonalComputer pc = new PersonalComputer();
            pc.On();
            pc.Off();

            Console.ReadKey();
        }
    }
}
