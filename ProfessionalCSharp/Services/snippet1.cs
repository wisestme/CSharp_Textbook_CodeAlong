using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalCSharp.Services
{
    class snippet1
    {
        public static void variables()
        {
            var name = "Bugs Bunny";
            var age = 25;
            var isRabbit = true;

            Type nameType = name.GetType();
            Type ageType = age.GetType();
            Type isRabbitType = isRabbit.GetType();

            Console.WriteLine($"name: {name} is of type {nameType}");
            Console.WriteLine($"age: {age} is of type {ageType}");
            Console.WriteLine($"isRabbit{name} is of type {isRabbitType}");
        }
    }
}
