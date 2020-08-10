using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo.Services
{
    interface IInterfaceImplementation
    {
        void Print();
    }

    class Customer : IInterfaceImplementation
    {
        public void Print()
        {
            Console.WriteLine("Interface print method");
        }
    }
}
