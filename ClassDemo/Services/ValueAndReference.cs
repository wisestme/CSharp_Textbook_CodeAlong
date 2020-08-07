using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo.Services
{
    public class ValueAndReference
    {
        public void PassByValue(int v)
        {
            v = 10;
            Console.WriteLine("v inside method = {0}", v);
        }

        public void PassByReference(int[] r)
        {
            r[0] = 5;
            Console.WriteLine("r inside method = {0}", r[0]);
        }
    }
}
