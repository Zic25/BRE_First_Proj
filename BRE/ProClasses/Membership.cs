using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRE.ProClasses
{
    public class Membership
    {
        public string MembershipCreate()
        {
            Console.Write("Membership Create logic from Membership Class");
            return "Membership created";

        }
        public string MembershipUpgrade()
        {
            Console.Write("Membership Upgrade logic from Membership Class");
            return "Membership Upgraded";

        }

        public string AnyOneMembershipCreateorUpgrade()
        {
            MembershipCreate();
            MembershipUpgrade();

            return "Any one Membership Created or Upgraded done";
            
        }
    }
}
