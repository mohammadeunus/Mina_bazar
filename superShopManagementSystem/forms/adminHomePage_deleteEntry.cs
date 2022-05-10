using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace superShopManagementSystem.forms
{
    public partial class adminHomePage_deleteEntry : Form
    {
        string sp_delete;
        public adminHomePage_deleteEntry()
        {
            InitializeComponent();
        }

        private void DeleteManagerButton_Click(object sender, EventArgs e)
        {
            try
            {
                Connection CN = new Connection();
                if (radioButtonclassBase.optionRadio == ENUMsalesManORmanager.salesMan)
                {
                    //title
                    label1.Text = "AdminPage: salesMan New Entry";
                    //querrySalesMan
                    sp_delete = "Delete from salesman where ID= '" + this.DeleteIdBoxManager.Text + "'";
                }
                else
                {
                    //title
                    label1.Text = "AdminPage: inventoryManager New Entry";
                    //querry inventory_manager
                    sp_delete = "Delete from inventory_login where ID= '" + this.DeleteIdBoxManager.Text + "'";
                }

                CN.thisConnection.Open();
                SqlCommand cmd = new SqlCommand(sp_delete, CN.thisConnection);


                int i = cmd.ExecuteNonQuery();

                CN.thisConnection.Close();
                if (i < 1)
                {
                    ERRORLABEL.Text = "data not found";
                }

                CN.thisConnection.Close();

            }
            catch (Exception ex)
            {
                ERRORLABEL.Text = ex.ToString();
            }
            
             
        }
    }
}
