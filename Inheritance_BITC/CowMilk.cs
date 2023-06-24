using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_BITC
{
    internal class CowMilk : Milk
    {
        private string CowBreed { get; set; }
        public CowMilk(string cowBreed, DateTime expiryDate, bool isExpired, bool isOrganic) : base(expiryDate, isExpired, isOrganic)
        {
            CowBreed = cowBreed;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Cow Breed: {CowBreed}\nExpire Date: {ExpiryDate}\nIsExpired: {IsExpired}\nIsOrganic: {IsOrganic}");
        }
    }
}
