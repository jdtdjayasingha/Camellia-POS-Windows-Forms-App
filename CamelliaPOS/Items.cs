using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamelliaPOS
{
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlDashboard_Click(object sender, EventArgs e)
        {
            Categories categoriesObj = new Categories();
            this.Hide();
            categoriesObj.ShowDialog();
            this.Close();
        }

        private void pnlItems_Click(object sender, EventArgs e)
        {
            Items itemsObj = new Items();
            this.Hide();
            itemsObj.ShowDialog(); 
            this.Close();
        }

        private void pnlCategories_Click(object sender, EventArgs e)
        {
            Categories categoriesObj = new Categories();
            this.Hide();
            categoriesObj.ShowDialog();
            this.Close();
        }

        private void pnl_Click(object sender, EventArgs e)
        {
            Customers customersObj = new Customers();
            this.Hide();
            customersObj.ShowDialog();
            this.Close();
        }

        private void pnlBilling_Click(object sender, EventArgs e)
        {
            Bill billObj = new Bill();
            this.Hide();
            billObj.ShowDialog();
            this.Close();
        }
    }
}
