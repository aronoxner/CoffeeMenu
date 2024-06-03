using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CoffeeList : Form
    {
        public CoffeeList()
        {
            InitializeComponent();
        }
        private void RefreshData()
        {
            coffeeGrid.DataSource = null;
            coffeeGrid.DataSource = Data.coffeeList;
            AdjustColumnHeader();
            AdjustColumnOrder();
        }

      
        public void CoffeeList_Load(object sender, EventArgs e)
        {
            coffeeGrid.DataSource = Data.coffeeList;
            AdjustColumnHeader();
            AdjustColumnOrder();
        }

        private void AdjustColumnHeader()
        {
            coffeeGrid.Columns["CoffeePrice"].Visible = false;
            coffeeGrid.Columns["CoffeeType"].HeaderText = "Coffee Type";
            coffeeGrid.Columns["BeverageSize"].HeaderText = "Beverage Size";
            coffeeGrid.Columns["DateTranscation"].HeaderText = "Transaction Time";
        }
        private void AdjustColumnOrder()
        {
            coffeeGrid.Columns["DateTranscation"].DisplayIndex = 0;
            coffeeGrid.Columns["CoffeeType"].DisplayIndex = 1;
            coffeeGrid.Columns["BeverageSize"].DisplayIndex = 2;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var userDecision = MessageBox.Show("Are you sure you want to delete the record?", "Warning", MessageBoxButtons.YesNo);
            if (userDecision == DialogResult.Yes)
            {
                Data.coffeeList.RemoveAt(coffeeGrid.CurrentRow.Index);
            }
            RefreshData();
        }
    }
}
