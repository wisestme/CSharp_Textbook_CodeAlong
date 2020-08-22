using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalCSharp
{
    class OverloadMethod
    {
        public void DisplayResult(string result)
        {
            Console.WriteLine($"This is a string result = {result}");
        }

        public void DisplayResult(int result)
        {
            Console.WriteLine($"This is an int result = {result}");
        }
    }
}
