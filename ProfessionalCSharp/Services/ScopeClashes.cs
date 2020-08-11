using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalCSharp.Services
{
    class ScopeClashes
    {
        public static void TestScoping()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            } // i has gone out of scope

            // so i can be reused
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
