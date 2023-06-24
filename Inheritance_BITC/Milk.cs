using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_BITC
{
    internal class Milk
    {
        private string Brand { get; set; }
        protected DateTime ExpiryDate { get; set; }
        protected bool IsExpired { get; set; }
        protected bool IsOrganic { get; set; }
        public Milk(DateTime expiryDate, bool isExpired, bool isOrganic)
        {
            ExpiryDate = expiryDate;
            IsExpired = isExpired;
            IsOrganic = isOrganic;
        }
        public Milk(string brand, DateTime expiryDate, bool isExpired, bool isOrganic) : this(expiryDate, isExpired, isOrganic)
        {
            Brand = brand;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}\nExpire Date: {ExpiryDate}\nIsExpired: {IsExpired}\nIsOrganic: {IsOrganic}");
        }
    }
}
