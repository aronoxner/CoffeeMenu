using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            comboCoffeeType.DataSource =Enum.GetValues(typeof(CoffeeType));
            comboCoffeeSize.DataSource =Enum.GetValues(typeof(BeverageSize));
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(comboCoffeeType.SelectedIndex != -1 && comboCoffeeSize.SelectedIndex != -1)
            {
                var newCoffee = new Coffee();
                newCoffee.DateTranscation = DateTime.Now;
                newCoffee.CoffeeType = (CoffeeType)(comboCoffeeType.SelectedIndex);
                newCoffee.BeverageSize = (BeverageSize) (comboCoffeeSize.SelectedIndex);
                Data.coffeeList.Add(newCoffee);
                MessageBox.Show("Order added!");
            }
        }

        private void btnCloseAddForm_Click(object sender, EventArgs e)
        {
            CoffeeList mainForm = new CoffeeList();
            mainForm.Show();
            this.Hide();
        }
    }
}
