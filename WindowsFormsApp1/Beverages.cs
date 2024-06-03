using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    enum BeverageSize
    {
        Small,
        Medium,
        Large
    }
    internal abstract class Beverages
    {
        public BeverageSize BeverageSize {  get; set; }


        public void OrderingQuestions()
        {
            MessageBox.Show("What type of beverage would you like to see?");
        }
    } 
}
