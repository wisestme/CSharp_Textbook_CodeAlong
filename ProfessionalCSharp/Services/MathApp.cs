using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalCSharp.Services
{
    interface IMath
    {
        int GetSquare();
    }
    public class MathApp : IMath
    {
        public int Value { get; set; }
        public int GetSquare()
        {
            return Value * Value;
        }

        public static int GetSquareOf(int x)
        {
            return x * x;
        }
       
        //internal static double Sqrt(double v)
        //{
            
        //}

        public static double GetPi()
        {
            return 3.14159;
        }
    }

    public class ManipulateMath
    {
        public static void Execute()
        {
            Console.WriteLine($"Pi is {MathApp.GetPi()}");
            int r = MathApp.GetSquareOf(5);
            Console.WriteLine($"The square of 5 is {r}");

            var math = new MathApp();
            math.Value = 6;
            Console.WriteLine($"The square of {math.Value} is {math.GetSquare()}");
        }
    }
}
