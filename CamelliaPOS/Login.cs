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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            Items itemsObj = new Items();
            this.Hide();
            itemsObj.ShowDialog();
            this.Close();
        }
    }
}
