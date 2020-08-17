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

        public void ImplementIfElseIf()
        {
            Console.WriteLine("Please enter some characters");

            string characters = Console.ReadLine();

            if (characters == "")
            {
                Console.WriteLine("You did not enter any character");
            }
            else if (characters.Length < 5)
                Console.WriteLine("The Characters you entered are less than 5");
            else if (characters.Length >= 5 && characters.Length < 10)
                Console.WriteLine("The characters you entered are from 5 to 9");
            else if (characters.Length >= 10)
                Console.WriteLine("The characters you entered are from 10 and above");
        }
    }
}
