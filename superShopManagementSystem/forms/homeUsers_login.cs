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
    public partial class homeUsers_login : Form
    {
        public homeUsers hmp;
        private string querry;
        int usertipe;

        public homeUsers_login(homeUsers homeuserPage,int userType)
        {
            usertipe=userType;

            this.hmp = homeuserPage;
            InitializeComponent();

            if (userType == 1)
            {
                pictureBox1.Image = imageList1.Images[0];

            }
            else if (userType == 2)
            {
                pictureBox1.Image = imageList1.Images[1];
            }
            else
            {
                pictureBox1.Image = imageList1.Images[2];
            }
        }


         

        private void homeUsers_login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //login button
            //check which user through usertipe integer
            if (usertipe == 1)//user is admin 
            {
                //check wich user authenticaion................................... 
                try
                {
                    Connection CN = new Connection();
                    //this query check whether the pass and id matches the data in server or not
                    querry = "SELECT * FROM admin_login WHERE id='" + userIdTextBox.Text + "' AND pass='" + userPassTextBox.Text + "'";

                    /*The SqlDataAdapter, serves as a bridge between a DataSet and SQL Server for retrieving and saving data.
                     *the following code was extracted from https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqldataadapter?view=dotnet-plat-ext-6.0
                     */
                    SqlDataAdapter sda = new SqlDataAdapter(querry, CN.thisConnection); 
                    
                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);
                    if (dtable.Rows.Count > 0)
                    {
                        adminHomePage oform = new adminHomePage(hmp);
                        oform.Show();
                        userPassTextBox.Clear();
                        this.Hide();
                    }
                    else
                    {
                        //adminLoginInfo.Text = "Admin: username or password incorrect";
                        userPassTextBox.Clear();
                    }
                    //this.Close();
                    CN.thisConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("admin, exception: "+ex.Message);
                }
            }
            else if (usertipe == 2)//user is inventoryManager
            {
                //check wich user authenticaion................................... 
                try
                {
                    Connection CN = new Connection();
                    querry = "SELECT * FROM inventory_login WHERE id='" + userIdTextBox.Text + "' AND pass='" + userPassTextBox.Text + "'";

                    SqlDataAdapter sda = new SqlDataAdapter(querry, CN.thisConnection);

                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);
                    if (dtable.Rows.Count > 0)
                    {
                        inventoryHomePage oform = new inventoryHomePage(hmp);
                        oform.Show();
                        userPassTextBox.Clear();
                        this.Hide();
                    }
                    else
                    {
                        adminLoginInfo.Text = "inventoryMananger: username or password incorrect";
                        userPassTextBox.Clear();
                    }
                    //this.Close();
                    CN.thisConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" inventoryMananger: Exception error:"+ ex.Message);
                }

            }
            else//user is saleMan
            {
                //check wich user authenticaion................................... 
                try
                {
                    Connection CN = new Connection();
                    querry = "SELECT * FROM salesman_login WHERE id='" + userIdTextBox.Text + "' AND pass='" + userPassTextBox.Text + "'";

                    SqlDataAdapter sda = new SqlDataAdapter(querry, CN.thisConnection);

                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);
                    if (dtable.Rows.Count > 0)
                    { 
                        //string? name = dtable.Rows[0]["name"].ToString();
                        salesmanHomePage oform = new salesmanHomePage(hmp, (dtable.Rows[0]["name"].ToString()) );
                        oform.Show();
                        userPassTextBox.Clear();
                        this.Hide();

                    }
                    else
                    {
                        adminLoginInfo.Text = "salesman: username or password incorrect";
                        userPassTextBox.Clear();
                    }
                    //this.Close();
                    CN.thisConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("salesman: Exception error: " + ex.Message);
                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            hmp.Show();
            this.Hide();
        } 
    }
}
