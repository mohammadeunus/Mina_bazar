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
    public partial class adminPage_ManagerDelete : Form
    {
        public adminPage_ManagerDelete()
        {
            InitializeComponent();
        }

        private void adminPage_ManagerDelete_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteManagerButton_Click(object sender, EventArgs e)
        {
            Connection CN = new Connection();
            string sp_delete = "Delete from MANAGERLOGININFO where ID= '" + this.DeleteIdBoxManager.Text + "'";
            CN.thisConnection.Open();
            SqlCommand cmd = new SqlCommand(sp_delete, CN.thisConnection);

            cmd.ExecuteNonQuery();

            CN.thisConnection.Close();
         
            ERRORLABEL.Text = DeleteIdBoxManager.Text + " deleted successfully";
          
            //DeleteIdBoxManager
        }
    }
}
