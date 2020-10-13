using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalCSharp.Services
{
    public class Enumeration
    {
        public enum Color : short
        {
            Red,
            Green,
            Blue
        }

        public void ColorSamples()
        {
            Color c1 = Color.Red;
            Console.WriteLine(c1);

            Color c2 = (Color)2;
            Console.WriteLine(c2);

            short number = (short)c2;
            Console.WriteLine(number);
        }

        
    }
}
