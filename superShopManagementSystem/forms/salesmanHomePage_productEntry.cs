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
    public partial class salesmanHomePage_productEntry : Form
    {
        public salesmanHomePage_productEntry()
        {
            InitializeComponent();
            saleSummery(true,"SELECT customerBillid as [Bill id],sellerName as [Seller Name], customerName as [Customer name], billdate as [Date], totalbill as [total]  FROM sellRecord");
            saleSummery(false, "SELECT * FROM productlist");
        }
        void saleSummery(bool d,string querry)
        {
            try
            {
                Connection CN = new Connection();
                SqlDataAdapter sda = new SqlDataAdapter(querry, CN.thisConnection);
                DataTable ftable = new DataTable();
                sda.Fill(ftable);
                if (d == false)
                {
                    dataGridView2.DataSource = ftable;
                }
                else
                {
                    dataGridView3.DataSource = ftable;
                }
                
                CN.thisConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
