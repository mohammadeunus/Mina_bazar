﻿using System;
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
        public inventoryHomePage_showStock()
        {
            InitializeComponent();
            saleSummery("SELECT * FROM productlist");
        }
        void saleSummery(string querry)
        {

            try
            {
                Connection CN = new Connection();
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
                Connection CN = new Connection();
                //querrySalesMan
                sp_insert = "INSERT INTO productlist (productname, prodqty) VALUES('" + textBoxProductname.Text + "', '" + textBoxProductquantity.Text + "'); ";

                CN.thisConnection.Open();
                SqlCommand cmd = new SqlCommand(sp_insert, CN.thisConnection);

                int i = cmd.ExecuteNonQuery();

                CN.thisConnection.Close();
                if (i == 1)
                {
                    ERRORLABEL.Text = i + " Data Saved";
                    saleSummery("SELECT * FROM productlist");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
