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
        inventoryHomePage_showStock hm1 = new inventoryHomePage_showStock();
        public inventoryHomePage(homeUsers homePage)
        {
            this.hmpg = homePage;
            InitializeComponent();
            loadform(hm1);
        }
        public void loadform(object Form)
        {
            if (this.mainPanelManagerPage.Controls.Count > 0)
            {
                this.mainPanelManagerPage.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanelManagerPage.Controls.Add(f);
            this.mainPanelManagerPage.Tag = f;
            f.Show();
        }
        //inventoryHomePage_showStock

        private void logout_Click(object sender, EventArgs e)
        {
            hmpg.Show();
            this.Hide();
        }
    }
}
