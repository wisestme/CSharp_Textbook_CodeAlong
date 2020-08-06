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

        public int[] ReturnUserInput()
        {
            int[] a = new int[3];

            for(int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter an integer: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Integer added to array. \n");
            }

            return a;
        }

        public List<int> ReturnUserInputList()
        {
            List<int> l = new List<int>();
            int input;

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter an integer: ");
                input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("integer added to list. \n");
                l.Add(input);
            }

            return l;
        }

        public void PrintNames(params string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i] + " ");
            }
            Console.WriteLine();
        }
        
    }
}