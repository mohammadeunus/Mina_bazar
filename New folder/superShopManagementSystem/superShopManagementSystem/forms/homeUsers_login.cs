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
        //public homeUsers hmp;
        public homeUsers_login(int userType)
        {

            //this.hmp = homeUsers;
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

            //check wich user.................................................
            try
            {
                Connection CN = new Connection();
                querry = "SELECT * FROM admin_login WHERE id='" + userIdTextBox.Text + "' AND pass='" + userPassTextBox.Text + "'";

                SqlDataAdapter sda = new SqlDataAdapter(querry, CN.thisConnection);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    if (userType == 1)
                    {
                        adminHomePage oform = new adminHomePage();
                        oform.Show();
                        userPassTextBox.Clear();
                        this.Hide();
                    }
                    else if (userType == 2)
                    {
                        inventoryHomePage oform = new inventoryHomePage();
                        oform.Show();
                        userPassTextBox.Clear();
                        this.Hide();
                    }
                    else
                    {
                        salesmanHomePage oform = new salesmanHomePage();
                        oform.Show();
                        userPassTextBox.Clear();
                        this.Hide();
                    }


                }
                else
                {
                    adminLoginInfo.Text = "Admin: username or password incorrect";
                    userPassTextBox.Clear();
                }
                //this.Close();
                CN.thisConnection.Close();
            }
            catch (Exception ex)
            {
                adminLoginInfo.Text = "Admin: Exception error: " + ex.ToString();
            }


        }
        private string querry;

         

        private void homeUsers_login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
