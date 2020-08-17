using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalCSharp.Services
{
    class Loops
    {
        public void ImplementForLoop()
        {
            for (int c = 0; c <= 100; c+=5)
            {
                Console.WriteLine(c);
            }
        }

        public void NestedForLoop()
        {
            for (int i = 0; i < 100; i+=10)
            {
                for (int j = i; j < i + 10; j++)
                {
                    Console.Write($" {j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
