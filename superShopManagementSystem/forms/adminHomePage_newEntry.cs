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
            Connection CN = new Connection();
            if (radioButtonclassBase.optionRadio == ENUMsalesManORmanager.salesMan)
            {
                //querrySalesMan
                sp_insert = "INSERT INTO salesman (ID, PASS) VALUES('" + EntryIdManager.Text + "', '" + EntryPassBoxManager.Text + "'); ";
            }
            else
            {
                //querry inventory_manager
                sp_insert = "INSERT INTO inventory_login (ID, PASS) VALUES('" + EntryIdManager.Text + "', '" + EntryPassBoxManager.Text + "'); ";
            }
            CN.thisConnection.Open();
            SqlCommand cmd = new SqlCommand(sp_insert, CN.thisConnection);

            int i = cmd.ExecuteNonQuery();

            CN.thisConnection.Close();
            if (i > 0)
            {
                ERRORLABEL.Text = i + " Data Saved";
            }
        }
    }
}
