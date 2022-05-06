using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_management_system.forms
{
    public partial class managerPage : Form
    {
        homePage hmpg;
        
        managerPage_NewBookEntry mng1 = new managerPage_NewBookEntry();
        managerPage_UpdateBookStock mng2 = new managerPage_UpdateBookStock();
        managerPage_SearchBook mng3 = new managerPage_SearchBook();
        managerPage_DeleteBookStock mng4 = new managerPage_DeleteBookStock();
        managerPage_bookStockList mng5 = new managerPage_bookStockList();

        public managerPage(homePage homePage)
        {
            this.hmpg = homePage;   
            InitializeComponent();
            loadform(mng1);
        }
        public void loadform(object Form)
        {
            if (this.mainPanelManagerPage.Controls.Count > 0)
            {
                this.mainPanelManagerPage.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanelManagerPage.Controls.Add(f);
            this.mainPanelManagerPage.Tag = f;
            f.Show();
        }

        private void managerPage_Load(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            hmpg.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(mng1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(mng2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(mng3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(mng4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadform(mng5);
        }
    }
}
