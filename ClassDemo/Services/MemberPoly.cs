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

        public override string ToString()
        {
            return "\nMember Name: " + memberName +
                "\nMember ID: " + memberID +
                "\nMember Since: " + memberSince;
        }
    }
}
