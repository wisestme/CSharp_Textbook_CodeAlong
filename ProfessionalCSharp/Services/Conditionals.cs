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
                    Console.WriteLine($"{i} is zero");
                }
                else
                {
                    isZero = false;
                    Console.WriteLine($"{i} is non-zero");
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

        public void ImplementSwitch()
        {
            int integerValue = 4;

            switch (integerValue)
            {
                case 1:
                    Console.WriteLine("Value is one");
                    break;
                case 2:
                    Console.WriteLine("Value is two");
                    break;
                case 3:
                    Console.WriteLine("Value is three");
                    break;
                case 4:
                    Console.WriteLine("Value is four");
                    break;
                default:
                    Console.WriteLine("Number need an upgrade or downgrade");
                    break;
            }
        }

        public void InteractiveSwitch()
        {
            Console.WriteLine("Please enter a number for interactive switch");

            int userChoice;
            string userChoiceString = Console.ReadLine();

            if(Int32.TryParse(userChoiceString, out userChoice))
            {
                switch (userChoice)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                        Console.WriteLine($"your number is {userChoice}");
                        break;
                    default:
                        Console.WriteLine("Beyond our scope");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input: Only numbers are allowed");
            }
        }
    }
}
