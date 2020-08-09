using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo.Services
{
    public class MemberInheritanceDemo
    {
        protected int annualFee;
        private string name;
        private int memberID;
        private int memberSince;

        public MemberInheritanceDemo()
        {
            Console.WriteLine("Parent Constructor with no parameter");
        }

        public MemberInheritanceDemo(string pName, int pMemberID, int pMemberSince)
        {
            Console.WriteLine("Parent Constructor with parameters");

            name = pName;
            memberID = pMemberID;
            memberSince = pMemberSince;
        }

        public override string ToString()
        {
            return "\nName: " + name + "\nMember ID: " + memberID +
                "\nMember Since: " + memberSince + "\nTotal Annual Fee: " +
                annualFee;
        }
    }

    public class RegularMember : MemberInheritanceDemo
    {
        public RegularMember()
        {
            Console.WriteLine("Child constructor with no parameter");
        }

        public RegularMember(string remarks, string name, int memberID, int memberSince) : base(name, memberID, memberSince)
        {
            Console.WriteLine("Child Constructor with 4 parameters");
            Console.WriteLine("Remarks = {0}", remarks);
        }

        public void CalculateAnnualFee()
        {
            annualFee = 100 + 12 * 30;
            Console.WriteLine(annualFee);
        }
    }

    public class VipMember : MemberInheritanceDemo
    {
        public VipMember()
        {
            Console.WriteLine("Second child constructor with no parameter");
        }

        public VipMember(string name, int memberID, int memberSince)
        {
            Console.WriteLine("Second child constructor with parameters");
        }

        public void CalculateAnnualFee()
        {
            annualFee = 1200;
        }
    }
}
