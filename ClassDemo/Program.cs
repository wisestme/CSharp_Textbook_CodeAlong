using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ClassDemo.Services;

namespace ClassDemo
{
    class Staff
    {
        private string nameOfStaff;
        private const int hourlyRate = 30;
        private int hWorked;

        public int HoursWorked
        {
            get
            {
                return hWorked;
            }
            set
            {
                if (value > 0)
                    hWorked = value;
                else
                    hWorked = 0;
            }
        }

        public void PrintMessage()
        {
            Console.WriteLine("Calculating Pay...");
        }

        public int CalculatePay()
        {
            PrintMessage();

            int staffPay;
            staffPay = hWorked * hourlyRate;

            if (hWorked > 0)
                return staffPay;
            else
                return 0;
        }

        public int CalculatePay(int bonus, int allowance)
        {
            PrintMessage();

            if (hWorked > 0)
                return hWorked * hourlyRate + bonus + allowance;
            else
                return 0;
        }

        public override string ToString()
        {
            //return "name of staff = " + nameOfStaff + ", hourlyRate = " + hourlyRate + ", hWorked = " + hWorked;
            return nameOfStaff;
        }

        public Staff(string name)
        {
            nameOfStaff = name;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("------------------------");
        }

        int age;
        public int StaffAge
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public Staff(string firstName, string lastName)
        {
            nameOfStaff = firstName + " " + lastName;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("-------------------");
        }
    }

    class Program
    {
        static void Main()
        {
            MemberInheritanceDemo gymUser = new MemberInheritanceDemo();
            RegularMember gymer = new RegularMember("very good", "Chijioke", 40, 50);
            VipMember vipGymer = new VipMember();
            gymer.CalculateAnnualFee();
            Console.WriteLine(gymer.ToString());

            int v = 2;
            int[] r = { 1, 2, 3, };

            ValueAndReference valRef = new ValueAndReference();
            Console.WriteLine("v before = {0}", v);
            valRef.PassByValue(v);
            Console.WriteLine("v before = {0}", v);
            Console.WriteLine("\n\n");

            Console.WriteLine("r[0] before = {0}", r[0]);
            valRef.PassByReference(r);
            Console.WriteLine("r[0] after = {0}", r[0]);

            ArraysLists arr = new ArraysLists();
            arr.PrintFirstElement(arr.TheArray);

            arr.PrintFirstElement(arr.TheList);

            int[] myNewArray = arr.ReturnUserInput();
            Console.WriteLine(myNewArray);

            var myNewList = arr.ReturnUserInputList();
            //Console.WriteLine(myNewList);

            foreach(var item in myNewList)
            {
                Console.Write(item + ", " );
            }

            arr.PrintNames("Chijioke", "Gloria", "Wisest");

            // Access non static members from StaticClass external class
            StaticClass nonStaticMembers = new StaticClass();
            Console.WriteLine(nonStaticMembers.message);
            nonStaticMembers.Name = "Chijioke";
            nonStaticMembers.DisplayName();

            // Access static members from StaticClass external class
            StaticClass.Age = 33;
            Console.WriteLine(StaticClass.greetings);
            StaticClass.DisplayAge();

            int pay;

            Staff staff1 = new Staff("Peter");

            staff1.HoursWorked = 160;
            pay = staff1.CalculatePay(1000, 400);
            Console.WriteLine("Pay = {0}", pay);

            Staff staff2 = new Staff("Jane", "Lee");
            staff2.HoursWorked = 100;
            staff2.StaffAge = 33;
            pay = staff2.CalculatePay();
            Console.WriteLine("Pay = {0} and Age = {1}", pay, staff2.StaffAge);

            Staff staff3 = new Staff("Carol");
            staff3.StaffAge = 26;
            staff3.HoursWorked = -10;
            pay = staff3.CalculatePay();
            Console.WriteLine("{0} is {1} years old, his pay = {2}", staff3, staff3.StaffAge, pay);
            Console.WriteLine("{0}", staff3);
        }
    }
}
