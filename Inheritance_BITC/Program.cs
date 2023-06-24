using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_BITC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Milk -----");
            Milk milk = new Milk("Marianna", DateTime.Parse("30.06.2023"), false, true);
            milk.DisplayInfo();

            Console.WriteLine("\n----- CowMilk -----");
            CowMilk cowMilk = new CowMilk("Holstein Friesian", DateTime.Parse("24.06.2023"), true, false);
            cowMilk.DisplayInfo();

            Console.WriteLine("\n----- GoatMilk -----");
            GoatMilk goatMilk = new GoatMilk("American Pygmy", DateTime.Parse("25.06.2023"), true, true);
            goatMilk.DisplayInfo();

            Console.WriteLine("\n----- SoyMilk -----");
            SoyMilk soyMilk = new SoyMilk(DateTime.Parse("05.07.2023"), false, false);
            soyMilk.DisplayInfo();
        }
    }
}
