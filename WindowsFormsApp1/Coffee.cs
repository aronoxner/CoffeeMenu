using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    enum CoffeeType
    {
        Espresso,
        Latte,
        Black,
        Mocha,
        Americano,
        Cappuccino,
        Macchiato
    }
    internal class Coffee : Beverages
    {

        private float coffeeprice;
        public float CoffeePrice { get { return coffeeprice; } }
        public CoffeeType CoffeeType { get; set; }
        public DateTime DateTranscation { get; set; }
  
        public float CalculateCoffeeCost(float coffeeprice, string BeverageSize)
        {
            if (BeverageSize == "Small")
            {
                coffeeprice += 1f;
            }
            else if (BeverageSize == "Medium")
            {
                coffeeprice += 2f;
            }
            else if(BeverageSize =="Large")
            {
                coffeeprice += 3f;
            }
            return coffeeprice;
        }
    }
}
