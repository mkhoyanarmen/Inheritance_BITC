using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_BITC
{
    internal class SoyMilk : Milk
    {
        public SoyMilk(DateTime expiryDate, bool isExpired, bool isOrganic):base(expiryDate, isExpired, isOrganic)
        {

        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Expire Date: {ExpiryDate}\nIsExpired: {IsExpired}\nIsOrganic: {IsOrganic}");
        }
    }
}
