using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace superShopManagementSystem.forms
{
    
    public partial class inventoryHomePage : Form
    {
        homeUsers hmpg;
        public inventoryHomePage(homeUsers homePage)
        {
            this.hmpg = homePage;
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            hmpg.Show();
            this.Hide();
        }
    }
}
