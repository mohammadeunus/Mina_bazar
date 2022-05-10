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
            radioButtonInventoryManager.Focus();
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
        private bool radioButtonCheck()
        {
            if (radioButtonInventoryManager.Checked == false || radioButtonInventoryManager.Checked == false)
            {
                /*check whether the radio button is pressed or not
                 */
                label1.Text = "cant be unchecked";
                return false;
            }
            return true;

        }

        private void checkList_Click(object sender, EventArgs e)
        {
                        
            if(radioButtonCheck()==true)
            { 
                if (radioButtonInventoryManager.Checked)
                {
                    loadform(ch1);

                }
                if (radioButtonInventoryManager.Checked)
                {
                    loadform(ch1);
                }
            }
        }

        private void newEntry_Click(object sender, EventArgs e)
        {
            if (radioButtonCheck() == true)
            { 
                if (radioButtonInventoryManager.Checked)
                {
                    loadform(ch3);

                }
                if(radioButtonInventoryManager.Checked)
                {
                    loadform(ch3);
                }


            }

        }

        private void deleteEntry_Click(object sender, EventArgs e)
        {
            if (radioButtonCheck() == true)
            { 
                if (radioButtonInventoryManager.Checked)
                {
                    loadform(ch2);

                }
                if (radioButtonInventoryManager.Checked)
                {
                    loadform(ch2);
                }

            }

        }

        private void mainPanelAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            hmpg.Show();
            this.Hide();
        }
    }
}
