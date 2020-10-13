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

        [Flags]
        public enum DaysOfWeek
        {
            Monday = 0x1,
            Tuesday = 0x2,
            Wednesday = 0x4,
            Thursday = 0x8,
            Friday = 0x10,
            Saturday = 0x20,
            Sunday = 0x40
        }

        public void WeekDays()
        {
            DaysOfWeek mondayAndWednesdayAndThursday = DaysOfWeek.Monday | DaysOfWeek.Wednesday | DaysOfWeek.Thursday;
            Console.WriteLine(mondayAndWednesdayAndThursday);
        }
    }
}
