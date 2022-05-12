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

    public partial class adminHomePage : Form
    {
        homeUsers hmpg;

        adminHomePage_CheckList ch1 = new adminHomePage_CheckList();
        adminHomePage_deleteEntry ch2 = new adminHomePage_deleteEntry();
        adminHomePage_newEntry ch3 = new adminHomePage_newEntry();
        public adminHomePage(homeUsers homePage)
        {
            this.hmpg = homePage;
            InitializeComponent();
            loadform(ch1);
            radioButtonclassBase.optionRadio = ENUMsalesManORmanager.inventoryManager;

        }


        public void loadform(object Form)
        {
            if (this.mainPanelAdmin.Controls.Count > 0)
            {
                this.mainPanelAdmin.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanelAdmin.Controls.Add(f);
            this.mainPanelAdmin.Tag = f;
            f.Show();
        }
        public void  radioCheck()
        {
            if (radioButtonInventoryManager.Checked)
            {
                radioButtonclassBase.optionRadio = ENUMsalesManORmanager.inventoryManager;
            }
            if (radioButtonISalesManager.Checked)
            {
                radioButtonclassBase.optionRadio = ENUMsalesManORmanager.salesMan;
            }
        }
        private void checkList_Click(object sender, EventArgs e)
        {            
            radioCheck();
            ch1 = new adminHomePage_CheckList();
            loadform(ch1);

        }

        private void newEntry_Click(object sender, EventArgs e)
        {
            radioCheck();
            ch3 = new adminHomePage_newEntry();
            loadform(ch3);
        }

        private void deleteEntry_Click(object sender, EventArgs e)
        {
            radioCheck();
            ch2 = new adminHomePage_deleteEntry();
            loadform(ch2);
        }

        private void mainPanelAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            hmpg.Show();
            this.Hide(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
