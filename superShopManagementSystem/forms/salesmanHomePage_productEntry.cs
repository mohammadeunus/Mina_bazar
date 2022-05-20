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
        string? bk_update,seller;

        //table create
        DataTable custTable = new DataTable();
        DataColumn? dtColumn;
        DataRow? myDataRow;
        salesmanHomePage_print shp;
        //total
        long totalPrice, totalQty;

        Connection CN = new Connection();
        private int prc;
        private string Billid;
        private string customername;

        public salesmanHomePage_productEntry(string seller)
        {
            this.seller= seller; 
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

            // Create unitprice column
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(Int32);
            dtColumn.ColumnName = "unitprice";
            dtColumn.Caption = "unitprice";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            // Add column to the DataColumnCollection.
            custTable.Columns.Add(dtColumn);

            // Create price column
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(Int32);
            dtColumn.ColumnName = "price";
            dtColumn.Caption = "price";
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
                MessageBox.Show("salesummer: " + ex.Message);
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

                    prc = (int)da.GetValue(0);
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
                MessageBox.Show("buttonaddproduct: " + ex.Message);
            }


            DataTable dataIntoTable()
            {
                //adding new row
                myDataRow = custTable.NewRow();
                myDataRow["CustomerName"] = textBoxCustomerName.Text;
                myDataRow["billid"] = textBoxBillid.Text;
                myDataRow["productname"] = textBoxProductName.Text;
                myDataRow["prodqty"] = textBoxQuantity.Text;
                myDataRow["unitprice"] = (int)prc;
                myDataRow["price"] = (int)myDataRow["prodqty"] * prc;
                custTable.Rows.Add(myDataRow);

                //information for receipt making................
                Billid = textBoxBillid.Text;
                customername = textBoxCustomerName.Text;
                totalPrice = (long)(custTable.Compute("SUM(Price)", string.Empty));
                totalQty = (long)(custTable.Compute("SUM(prodqty)", string.Empty));

                textBoxTotalItem.Text = totalQty.ToString();
                textBoxTotalBill.Text = totalPrice.ToString();

                return custTable;
            }

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (custTable.Rows.Count > 0)
            {
                try
                {
                    bk_update = "insert into sellrecord(customerBillid, sellerName, billDate, totalBill, customerName) values('" + Billid + "' , '" + seller + "', '" + DateTime.Now + "', '" + totalPrice + "' , '" + customername + "' ) ";
                    CN.thisConnection.Open();

                    SqlCommand cmd = new SqlCommand(bk_update, CN.thisConnection);

                    int i = cmd.ExecuteNonQuery();

                    CN.thisConnection.Close();
                    if (i == 1)
                    {
                        printPreviewDialog1.Document = printDocument1;
                        printPreviewDialog1.ShowDialog();
                        label10.Text = ("datasaved");
                        custTable.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("printDocument1_PrintPage: " + ex.Message);

                    CN.thisConnection.Close();
                }
                 
            }
            else
            {
                MessageBox.Show("dataTable is empty");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            custTable.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // ////////////////////////// printout / receipt of the ordered list by cutomer ////////////////////////////////////////////
 
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
             int nextLine = 120;
            e.Graphics.DrawString("MINA BAZAR", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(360, nextLine));
            e.Graphics.DrawString("___________________________________", new Font("Arial", 20), Brushes.Black, new Point(175, nextLine));
            nextLine += 30;
            e.Graphics.DrawString("sale receipt", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(380, nextLine));
            nextLine += 30;
            e.Graphics.DrawString("PRINCIPLE ABUL KALAM ROAD, MIPRPUR-1", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(200, nextLine));
            nextLine += 30;
            e.Graphics.DrawString("DHAKA-1216", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(380, nextLine));
            nextLine += 30;
            e.Graphics.DrawString("CONTACT NUMBER: +88-01521430101", new Font("Arial", 16), Brushes.Black, new Point(230, nextLine));
            nextLine += 60;

            e.Graphics.DrawString("Bill id : " + Billid, new Font("Arial", 16), Brushes.Black, new Point(70, nextLine));
            nextLine += 30;
            e.Graphics.DrawString("Receipt issued to : " + customername, new Font("Arial", 16), Brushes.Black, new Point(70, nextLine));
            nextLine += 30;
            e.Graphics.DrawString("Receipt issuing date : " + DateTime.Now.ToString(), new Font("Arial", 16), Brushes.Black, new Point(70, nextLine));


            nextLine += 75;
            e.Graphics.DrawString("__________________________________________________", new Font("Arial", 15), Brushes.Black, new Point(70, nextLine));
            e.Graphics.DrawString("Product Name      Product Quantity      Unit Price      Total price", new Font("Arial", 15), Brushes.Black, new Point(70, nextLine));
            nextLine += 30;
            foreach (DataRow row in custTable.Rows)
            {
                nextLine += 30;
                e.Graphics.DrawString(row["productname"] + "    " + row["prodqty"] + "    " + row["unitprice"] + "    " + row["price"], new Font("Arial", 15), Brushes.Black, new Point(70, nextLine));
            }
            nextLine += 30;
            e.Graphics.DrawString("_______________________________________________", new Font("Arial", 15), Brushes.Black, new Point(70, nextLine));
            nextLine += 30;
            e.Graphics.DrawString("Total quantity: " + totalQty + "      Total price: " + totalPrice, new Font("Arial", 15), Brushes.Black, new Point(70, nextLine));


        }
    }
}
