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

        public void ImplementWhileLoop()
        {
            int i = 20;

            while(i > 10)
            {
                Console.WriteLine(i);
                i--;
            }
        }

        public void ImplementDoWhile()
        {
            int i = 20;
            do
            {
                Console.WriteLine($"{i} in a do while loop");
                i -= 2;
            }
            while (i > 10);
        }
    }
}
