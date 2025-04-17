using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37_5
{
    internal class TVSet : ISwitchable
    {
        public void On()
        {
            Console.WriteLine("Телевизор ВКЛЮЧЕН");
        }
        public void Off()
        {
            Console.WriteLine("Телевизор ВЫКЛЮЧЕН");
        }
    }
}
