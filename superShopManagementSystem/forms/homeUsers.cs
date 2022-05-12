using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace superShopManagementSystem.forms
{


    public partial class homeUsers : Form
    {
        homeUsers_login oform; 
        public homeUsers()
        {
            InitializeComponent();
        }
        

        private void homeUsers_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            oform = new homeUsers_login(this,1);
            oform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            oform = new homeUsers_login(this, 2);
            oform.Show();
            this.Hide(); 
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            oform = new homeUsers_login(this, 3);
            oform.Show();
            this.Hide(); 
        }

        private void EXITpictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
