using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo.Services
{
    class MemberPoly
    {
        protected int annualFee;
        private string memberName;
        private int memberID;
        private int memberSince;

        public MemberPoly()
        {
            Console.WriteLine("Parameterless parent class constructor");
        }

        public MemberPoly(string pMemberName, int pMemberID, int pMemberSince)
        {
            Console.WriteLine("Parent class constructor with parameters");

            memberName = pMemberName;
            memberID = pMemberID;
            memberSince = pMemberSince;
        }

        public virtual void CalculateAnnualFee()
        {
            annualFee = 0;
        }

        public override string ToString()
        {
            return "\nMember Name: " + memberName +
                "\nMember ID: " + memberID +
                "\nMember Since: " + memberSince +
                "\nTotal Annual Fee: " + annualFee;
        }
    }

    class VIPMemberPoly : MemberPoly
    {
        public VIPMemberPoly(string memberName, int memberID, int memberSince) : base(memberName, memberID, memberSince)
        {
            
        }

        public override void CalculateAnnualFee()
        {
            annualFee = 600;
        }
    }

    class RegularMemberPoly : MemberPoly
    {
        public RegularMemberPoly(string remarks, string memberName, int memberID, int memberSince) : base(memberName, memberID, memberSince)
        {
            Console.WriteLine("child constructor with parameters");
        }

        public override void CalculateAnnualFee()
        {
            annualFee = 100 + 12 * 20; ;
        }
    }
}
