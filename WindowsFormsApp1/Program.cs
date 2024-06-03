using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Data.coffeeList.Add(new Coffee() { CoffeeType = CoffeeType.Espresso, BeverageSize = BeverageSize.Small, DateTranscation = DateTime.Now });
            Data.coffeeList.Add(new Coffee() { CoffeeType = CoffeeType.Americano, BeverageSize = BeverageSize.Medium, DateTranscation = DateTime.Now });
            Data.coffeeList.Add(new Coffee() { CoffeeType = CoffeeType.Americano, BeverageSize = BeverageSize.Small, DateTranscation = DateTime.Now });
            Data.coffeeList.Add(new Coffee() { CoffeeType = CoffeeType.Black, BeverageSize = BeverageSize.Large, DateTranscation = DateTime.Now });
            Data.coffeeList.Add(new Coffee() { CoffeeType = CoffeeType.Macchiato, BeverageSize = BeverageSize.Medium, DateTranscation = DateTime.Now });
            Data.coffeeList.Add(new Coffee() { CoffeeType = CoffeeType.Cappuccino, BeverageSize = BeverageSize.Small, DateTranscation = DateTime.Now });
            Data.coffeeList.Add(new Coffee() { CoffeeType = CoffeeType.Mocha, BeverageSize = BeverageSize.Large, DateTranscation = DateTime.Now });
            Data.coffeeList.Add(new Coffee() { CoffeeType = CoffeeType.Espresso, BeverageSize = BeverageSize.Small, DateTranscation = DateTime.Now });
            Application.Run(new CoffeeList());
        }
    }
}
