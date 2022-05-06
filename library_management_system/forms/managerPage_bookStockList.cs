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
    public partial class managerPage_bookStockList : Form
    {
        public managerPage_bookStockList()
        {
            InitializeComponent();
            datashow();
        }
        private void datashow()
        {
            Connection CN = new Connection();
            string querry = "SELECT * FROM bookTable";

            SqlDataAdapter sda = new SqlDataAdapter(querry, CN.thisConnection);

            DataTable fatable = new DataTable();
            sda.Fill(fatable);
            dataGridView1.DataSource = fatable;
            CN.thisConnection.Close();

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            datashow();
        }
    }
}
