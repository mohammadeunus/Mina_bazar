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
        public adminHomePage()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.mainPanelAdmin.Controls.Count > 0)
            {
                this.mainPanelAdmin.Controls.RemoveAt(0);
            }
            Form? f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanelAdmin.Controls.Add(f);
            this.mainPanelAdmin.Tag = f;
            f.Show();
        }

        private void checkList_Click(object sender, EventArgs e)
        {
            if (!radioButtonInventoryManager.Checked || !radioButtonISalesManager.Checked)
            {
                /*check whether the radio button is pressed or not
                 */
                errorProvider1.SetError(radioButtonInventoryManager, "cant be unchecked");
                radioButtonInventoryManager.Focus();
                
            }
            else
            {
                errorProvider1.Clear();
                if (radioButtonInventoryManager.Checked)
                {

                }
                if (radioButtonInventoryManager.Checked)
                {
                }
            }
        }

        private void newEntry_Click(object sender, EventArgs e)
        {
            if (!radioButtonInventoryManager.Checked || !radioButtonISalesManager.Checked)
            {
                /*check whether the radio button is pressed or not
                 */
                errorProvider1.SetError(radioButtonInventoryManager, "cant be unchecked");
                radioButtonInventoryManager.Focus();

            }
            else
            {
                errorProvider1.Clear();
                if (radioButtonInventoryManager.Checked)
                {

                }
                if(radioButtonInventoryManager.Checked)
                {
                }


            }

        }

        private void deleteEntry_Click(object sender, EventArgs e)
        {
            if (!radioButtonInventoryManager.Checked || !radioButtonISalesManager.Checked)
            {
                /*check whether the radio button is pressed or not
                 */
                errorProvider1.SetError(radioButtonInventoryManager, "cant be unchecked");
                radioButtonInventoryManager.Focus();

            }
            else
            {
                errorProvider1.Clear();
                if (radioButtonInventoryManager.Checked)
                {

                }
                if (radioButtonInventoryManager.Checked)
                {
                }

            }

        }
    }
}
