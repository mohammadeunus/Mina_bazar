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
    public partial class adminPage_ManagerList : Form
    {
        string querry;
        public adminPage_ManagerList()
        {
            InitializeComponent();
            datashow();
        }
        private void datashow()
        {
            Connection CN = new Connection();
            querry = "SELECT * FROM MANAGERLOGININFO ";

            SqlDataAdapter sda = new SqlDataAdapter(querry, CN.thisConnection);

            DataTable ftable = new DataTable();
            sda.Fill(ftable);
            dataGridView1.DataSource=ftable;
            CN.thisConnection.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adminPage_ManagerList_Load(object sender, EventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            datashow();
        }
    }
}
