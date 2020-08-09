using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo.Services
{
    class AbstractImplementation
    {
        public abstract class MyAbstractClass
        {
            private string message = "Hello Wisest";
            public void PrintMessage()
            {
                Console.WriteLine(message);
            }
            public abstract void PrintMessageAbstract();
        }
        
        public class NonAbstractClass : MyAbstractClass
        {
            public override void PrintMessageAbstract()
            {
                Console.WriteLine("C# is fun");
            }
        }
    }
}
