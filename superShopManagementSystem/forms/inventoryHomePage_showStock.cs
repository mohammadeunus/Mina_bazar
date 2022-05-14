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
    public partial class inventoryHomePage_showStock : Form
    {
        private string? bk_update;
        Connection CN = new Connection();
        public inventoryHomePage_showStock()
        {
            InitializeComponent();
            saleSummery("SELECT * FROM productlist");
        }
        void saleSummery(string querry)
        {

            try
            {
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

        private void refresh_Click(object sender, EventArgs e)
        {
            saleSummery("SELECT * FROM productlist");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string sp_insert;
            try
            {
                //querrySalesMan
                sp_insert = "INSERT INTO productlist (productname, prodqty, unitprice) VALUES('" + textBoxProductname.Text + "', '" + textBoxProductquantity.Text + "', '" + textBoxUnitPrice.Text + "'); ";

                CN.thisConnection.Open();
                SqlCommand cmd = new SqlCommand(sp_insert, CN.thisConnection);

                int i = cmd.ExecuteNonQuery();

                CN.thisConnection.Close();
                if (i == 1)
                {
                    ERRORLABEL.Text = textBoxProductname.Text + " Data added";
                    saleSummery("SELECT * FROM productlist");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void inventoryHomePage_showStock_Load(object sender, EventArgs e)
        {

        }

        private void textBoxProductname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bk_update = "SELECT prodqty, unitprice FROM productlist where productname= '" + textBoxProductname.Text + "'";
                CN.thisConnection.Open();

                SqlCommand sdaa = new SqlCommand(bk_update, CN.thisConnection);

                SqlDataReader da = sdaa.ExecuteReader();
                 
                while (da.Read())
                {
                    textBoxProductquantity.Text = da.GetValue(0).ToString();
                    textBoxUnitPrice.Text = da.GetValue(1).ToString();
                }

                CN.thisConnection.Close();
                saleSummery("SELECT * FROM productlist");


            }

            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bk_update = "UPDATE productlist SET productname = '" + textBoxProductname.Text + "' , prodqty = '" + textBoxProductquantity.Text + "', unitprice = '" + textBoxUnitPrice.Text + "' where productname = '" + textBoxProductname.Text + "' ";
                CN.thisConnection.Open();
                SqlCommand cmcd = new SqlCommand(bk_update, CN.thisConnection);

                cmcd.ExecuteNonQuery();

                CN.thisConnection.Close();
                ERRORLABEL.Text = textBoxProductname.Text + " Data updated";

                saleSummery("SELECT * FROM productlist");

            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string sp_delete = "Delete from productlist where productname= '" + this.textBoxProductname.Text + "'";
                CN.thisConnection.Open();
                SqlCommand cmd = new SqlCommand(sp_delete, CN.thisConnection);

                int i = cmd.ExecuteNonQuery();

                CN.thisConnection.Close();
                if (i > 0)
                {
                    ERRORLABEL.Text = textBoxProductname.Text + " is deleted successfully";
                }
                else
                {
                    ERRORLABEL.Text = textBoxProductname.Text + " is not found in database.";
                }

                saleSummery("SELECT * FROM productlist");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
