using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace library_management_system.forms
{
    public partial class adminPage_NewManagerEntr : Form
    {
        public adminPage_NewManagerEntr()
        {
            InitializeComponent();
        }

        private void adminPage_NewManagerEntr_Load(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Connection CN = new Connection();
            string sp_insert = "INSERT INTO MANAGERLOGININFO (ID, PASSWORD) VALUES('" + EntryIdManager.Text + "', '" + EntryPassBoxManager.Text + "'); ";
            CN.thisConnection.Open();
            SqlCommand cmd = new SqlCommand(sp_insert, CN.thisConnection);

            int i = cmd.ExecuteNonQuery();

            CN.thisConnection.Close();
            if (i > 0)
            {
                ERRORLABEL.Text = i+" Data Saved";
            }

        }
    }
}


