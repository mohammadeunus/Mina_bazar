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
    public partial class salesmanHomPage_customer : Form
    {
        public salesmanHomPage_customer()
        {
            InitializeComponent();
            saleSummery();
        }
        
        void saleSummery()
        {
            Date.Text = DateTime.Now.ToString();
            string querry = "SELECT customerBillid as [Bill id],sellerName as [Seller Name], customerName as [Customer name], billdate as [Date], totalbill as [total]  FROM sellRecord";
            try
            {
                Connection CN = new Connection(); 
                SqlDataAdapter sda = new SqlDataAdapter(querry, CN.thisConnection);
                DataTable ftable = new DataTable();
                sda.Fill(ftable);
                dataGridView3.DataSource = ftable;
                CN.thisConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void buttonAddcusotomer_Click(object sender, EventArgs e)
        {

        }
    }
}
