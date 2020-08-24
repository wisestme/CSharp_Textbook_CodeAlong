using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalCSharp
{
    public static class UserPreference
    {
        public static Color BackColor { get;  }
        static UserPreference()
        {
            DateTime now = DateTime.Now;

            if (now.DayOfWeek == DayOfWeek.Saturday || now.DayOfWeek == DayOfWeek.Sunday)
            {
                BackColor = Color.Green;
            }
            else
            {
                BackColor = Color.Red;
            }

        }

        public enum Color
        {
            White,
            Red,
            Green,
            Blue,
            Black
        }

        
    }
}
