using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace library_management_system.forms
{
    public partial class homePage_ManagerLogin : Form
    {
        string querry;
        homePage hmp;
        public homePage_ManagerLogin(homePage homePage)
        {
            this.hmp = homePage;
            InitializeComponent();
        }
        private void logincheck()
        {
            try
            {

                Connection CN = new Connection();
                querry = "SELECT * FROM MANAGERLOGININFO WHERE id='" + idBoxManager.Text + "' AND password='" + passBoxManager.Text + "'";

                SqlDataAdapter sda = new SqlDataAdapter(querry, CN.thisConnection);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    managerPage oform2 = new managerPage(hmp);
                    oform2.Show();
                    passBoxManager.Clear();
                    hmp.Hide();

                }
                else
                {
                    managerLoginInfo.Text = "Admin: username or password incorrect";
                    passBoxManager.Clear();
                }
                //this.Close();
                CN.thisConnection.Close();

            }
            catch (Exception ex)
            {
                managerLoginInfo.Text = "Admin: Exception error: " + ex.ToString();
            }
        }

        private void HomePageManagerLogin_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.logincheck();
        }
    }
}
