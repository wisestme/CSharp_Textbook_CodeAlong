using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo.Services
{
    interface IInterfaceWisest
    {
        void Print();
    }

    interface I2
    {
        void I2Method();
    }

    class Customer2 : IInterfaceWisest, I2
    {
        public void I2Method()
        {
            Console.WriteLine("Multiple interface inheritance");
        }

        public void Print()
        {
            Console.WriteLine("Interface2 print method");
        }
    }
}
