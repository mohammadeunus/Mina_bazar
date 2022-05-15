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

        //table create
        DataTable custTable = new DataTable();
        DataColumn? dtColumn;
        DataRow? myDataRow;


        Connection CN = new Connection();
        public salesmanHomePage_productEntry()
        {
            InitializeComponent();
            saleSummery("SELECT * FROM productlist");
            createTable();
        }

        void createTable()
        {
            // Create customerName column
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "customerName";
            dtColumn.Caption = "customerName";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            // Add column to the DataColumnCollection.
            custTable.Columns.Add(dtColumn);

            // Create billid column
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(Int32);
            dtColumn.ColumnName = "billid";
            dtColumn.Caption = "billid";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            // Add column to the DataColumnCollection.
            custTable.Columns.Add(dtColumn);

            // Create productName column
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "productName";
            dtColumn.Caption = "productName";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = true;
            // Add column to the DataColumnCollection.
            custTable.Columns.Add(dtColumn);

            // Create productQuantity column
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(Int32);
            dtColumn.ColumnName = "prodqty";
            dtColumn.Caption = "prodqty";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            // Add column to the DataColumnCollection.
            custTable.Columns.Add(dtColumn);
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

            label6.Text = "asdfasdfasd";
            //check product available in list or not
            try
            {
                bk_update = "SELECT unitprice FROM productlist where productname= '" + textBoxProductName.Text + "'";
                CN.thisConnection.Open();

                SqlCommand sdaa = new SqlCommand(bk_update, CN.thisConnection);

                SqlDataReader da = sdaa.ExecuteReader();
                 
                if (da.HasRows)
                { 
                    CN.thisConnection.Close();
                    dataGridView1.DataSource = dataIntoTable();
                }
                else
                {
                    label6.Text = textBoxProductName.Text + " is not available in the inventory";
                } 
                CN.thisConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
            DataTable dataIntoTable()
            {   
                //adding new row
                myDataRow = custTable.NewRow();
                myDataRow["CustomerName"] = textBoxCustomerName.Text;
                myDataRow["billid"] = textBoxBillid.Text;
                myDataRow["productname"] = textBoxProductName.Text;
                myDataRow["prodqty"] = textBoxQuantity.Text; 
                custTable.Rows.Add(myDataRow);

                return custTable;
            }

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
