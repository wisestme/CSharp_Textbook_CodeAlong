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

            i = 10;
            if(i == 0)
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
    }
}
