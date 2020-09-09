using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProNotes.Services
{
    public delegate int NumberInOutDelegate(int NumberInput);
    public class DeclareDelegate
    {        
        public void ImplementDelegate()
        {
            
            NumberInOutDelegate callSquareOperation = MathOperation.Square;
            NumberInOutDelegate callCube = MathOperation.Cube;
            NumberInOutDelegate callDouble = MathOperation.Double;

            int fiveSquare = callSquareOperation(5);
            Console.WriteLine($"The square of 5 is {fiveSquare}");

            int fiveCube = callCube(5);
            Console.WriteLine($"The cube of 5 is {fiveCube}");

            int doubleFive = callDouble(5);
            Console.WriteLine($"The double of 5 is {doubleFive}");
        }
       

    }

    public class MathOperation
    {
        public static int Square (int x)
        {
            return x * x;
        }

        public static int Cube (int x)
        {
            return x * x * x; 
        }

        public static int Double (int x)
        {
            return x * 2;
        }
    }
}
