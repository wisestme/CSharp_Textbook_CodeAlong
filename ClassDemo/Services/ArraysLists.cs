using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo.Services
{
    class ArraysLists
    {
        public void PrintFirstElement(int[] a)
        {
            Console.WriteLine("The first element is {0} \n", a[0]);
        }

        int[] myArray = { 1, 2, 3, 4, 5 };
        public int[] TheArray
        {
            get
            {
                return myArray;
            }
            set
            {
                myArray = value;
            }
        }

        public void PrintFirstElement(List<int> a)
        {
            Console.WriteLine("The first element is {0} \n", a[0]);
        }

        List<int> myList = new List<int> { 5, 2, 3 };

        public List<int> TheList
        {
            get
            {
                return myList;
            }
            set
            {
                myList = value;
            }
        }
    }
}