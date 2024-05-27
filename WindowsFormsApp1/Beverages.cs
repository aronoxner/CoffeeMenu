using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal abstract class Beverages
    {
        private string bevaragesize;
        public string BeverageSize { get { return bevaragesize.ToUpper(); } set { bevaragesize = value; } }
        public bool ToGo { get; set; }

        public void OrderingSteps()
        {
            MessageBox.Show("What type of beverage would you like?");
            MessageBox.Show("What size of beverage do you want?");
            MessageBoxButtons
        }
    } 
}
