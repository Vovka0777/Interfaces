using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37_5
{
    internal class PersonalComputer : ISwitchable
    {
        public void On()
        {
            Console.WriteLine("Персональный компьютер ВКЛЮЧЕН");
        }
        public void Off()
        {
            Console.WriteLine("Персональный компьютер ВЫКЛЮЧЕН");
        }
    }
}
