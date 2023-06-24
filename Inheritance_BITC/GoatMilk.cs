using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_BITC
{
    internal class GoatMilk : Milk
    {
        private string GoatBreed { get; set; }
        public GoatMilk(string goatBreed, DateTime expiryDate, bool isExpired, bool isOrganic) : base(expiryDate, isExpired, isOrganic)
        {
            GoatBreed = goatBreed;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Goat Breed: {GoatBreed}\nExpire Date: {ExpiryDate}\nIsExpired: {IsExpired}\nIsOrganic: {IsOrganic}");
        }
    }
}
