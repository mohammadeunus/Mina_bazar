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
    public partial class adminHomePage_CheckList : Form
    {
        string? querry; 
        public adminHomePage_CheckList()
        { 
            InitializeComponent();
            datashow();
        }
        private void datashow()
        {
            try
            {
                Connection CN = new Connection();
                if (radioButtonclassBase.optionRadio == ENUMsalesManORmanager.salesMan)
                {
                    //querrySalesMan
                    querry = "SELECT * FROM salesman_login";
                }
                else
                {
                    //inventory_login
                    querry = "SELECT * FROM inventory_login";
                }
                SqlDataAdapter sda = new SqlDataAdapter(querry, CN.thisConnection);
                DataTable ftable = new DataTable();
                sda.Fill(ftable);
                dataGridView1.DataSource = ftable;
                CN.thisConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            datashow();
        }

        private void adminHomePage_CheckList_Load(object sender, EventArgs e)
        {

        }
    }
}
