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
        string? bk_update;

        Connection CN = new Connection();
        public salesmanHomePage_productEntry()
        {
            InitializeComponent();
            saleSummery("SELECT * FROM productlist");
        }
        void saleSummery(string querry)
        {
            Date.Text = DateTime.Now.ToString();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(querry, CN.thisConnection);
                DataTable ftable = new DataTable();
                sda.Fill(ftable);
                dataGridView2.DataSource = ftable;
                
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

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            saleSummery("SELECT * FROM productlist");
        }

        private void salesmanHomePage_productEntry_Load(object sender, EventArgs e)
        {

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {

        }

        private void textBoxProductName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bk_update = "SELECT unitprice FROM productlist where productname= '" + textBoxProductName.Text + "'";
                CN.thisConnection.Open();

                SqlCommand sdaa = new SqlCommand(bk_update, CN.thisConnection);

                SqlDataReader da = sdaa.ExecuteReader();

                while (da.Read())
                {
                    unitPrice.Text = da.GetValue(0).ToString(); 
                }

                CN.thisConnection.Close(); 
            }

            catch (Exception ex)
            {
                //
            }
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
