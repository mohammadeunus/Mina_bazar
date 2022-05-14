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
        string? customerName,bk_update;

        Connection CN = new Connection();
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
            //customerName =textBoxAddcusotomer.Text;
            //userNameBox

        }

        private void textBoxAddcusotomer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bk_update = "select * from sellrecord where customername = '" + textBoxAddcusotomer.Text + "' ";
                CN.thisConnection.Open();
                SqlCommand cmcd = new SqlCommand(bk_update, CN.thisConnection);

                int i = cmcd.ExecuteNonQuery();

                if (i !=1)
                {
                    errorLabel.Text = "possible new customer";
                }
                CN.thisConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
