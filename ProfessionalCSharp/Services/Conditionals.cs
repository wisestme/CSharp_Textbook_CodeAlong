using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalCSharp.Services
{
    class Conditionals
    {
        public void ImplementIfElse()
        {
            bool isZero;
            int i;

            Console.WriteLine("Please enter a number");
            string userNumber = Console.ReadLine();

            if (int.TryParse(userNumber, out i))
            {
                if (i == 0)
                {
                    isZero = true;
                    Console.WriteLine("i is zero");
                }
                else
                {
                    isZero = false;
                    Console.WriteLine("i is non-zero");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
            
        }
    }
}
