using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace superShopManagementSystem.forms
{
    public partial class adminHomePage_newEntry : Form
    {
        string sp_insert;
        public adminHomePage_newEntry()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                Connection CN = new Connection();
                if (radioButtonclassBase.optionRadio == ENUMsalesManORmanager.salesMan)
                {
                    //title
                    label1.Text = "AdminPage: salesMan New Entry";
                    //querrySalesMan
                    sp_insert = "INSERT INTO salesman_login (ID, PASS, NAME) VALUES('" + EntryIdManager.Text + "', '" + EntryPassBoxManager.Text + "', '" + textBoxName.Text + "'); ";
                }
                else
                {
                    //title
                    label1.Text = "AdminPage: inventoryManager New Entry";
                    //querry inventory_manager
                    sp_insert = "INSERT INTO inventory_login (ID, PASS, NAME) VALUES('" + EntryIdManager.Text + "', '" + EntryPassBoxManager.Text + "', '" + textBoxName.Text + "'); ";
                }
                CN.thisConnection.Open();
                SqlCommand cmd = new SqlCommand(sp_insert, CN.thisConnection);

                int i = cmd.ExecuteNonQuery();

                CN.thisConnection.Close();
                if (i == 1)
                {
                    ERRORLABEL.Text = i + " Data Saved";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void adminHomePage_newEntry_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
