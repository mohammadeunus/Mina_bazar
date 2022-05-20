namespace superShopManagementSystem.forms
{
    partial class salesmanHomePage_productEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(salesmanHomePage_productEntry));
            this.label2 = new System.Windows.Forms.Label();
            this.totalBill = new System.Windows.Forms.Label();
            this.textBoxTotalBill = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.textBoxBillid = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.Label();
            this.unitPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.textBoxTotalItem = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(583, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "Taka";
            // 
            // totalBill
            // 
            this.totalBill.AutoSize = true;
            this.totalBill.Location = new System.Drawing.Point(433, 410);
            this.totalBill.Name = "totalBill";
            this.totalBill.Size = new System.Drawing.Size(57, 15);
            this.totalBill.TabIndex = 36;
            this.totalBill.Text = "Total Bill :";
            // 
            // textBoxTotalBill
            // 
            this.textBoxTotalBill.Location = new System.Drawing.Point(496, 406);
            this.textBoxTotalBill.Name = "textBoxTotalBill";
            this.textBoxTotalBill.Size = new System.Drawing.Size(84, 23);
            this.textBoxTotalBill.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Product Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Unit price :";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(382, 152);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(140, 23);
            this.textBoxQuantity.TabIndex = 29;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 64);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(203, 336);
            this.dataGridView2.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(243, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(413, 175);
            this.dataGridView1.TabIndex = 25;
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.Silver;
            this.buttonPrint.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonPrint.Location = new System.Drawing.Point(663, 225);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(54, 104);
            this.buttonPrint.TabIndex = 23;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.BackColor = System.Drawing.Color.Silver;
            this.buttonAddProduct.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonAddProduct.Location = new System.Drawing.Point(545, 64);
            this.buttonAddProduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(68, 111);
            this.buttonAddProduct.TabIndex = 22;
            this.buttonAddProduct.Text = "Add product";
            this.buttonAddProduct.UseVisualStyleBackColor = false;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // textBoxBillid
            // 
            this.textBoxBillid.Location = new System.Drawing.Point(382, 94);
            this.textBoxBillid.Name = "textBoxBillid";
            this.textBoxBillid.Size = new System.Drawing.Size(140, 23);
            this.textBoxBillid.TabIndex = 29;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(382, 123);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(140, 23);
            this.textBoxProductName.TabIndex = 30;
            this.textBoxProductName.TextChanged += new System.EventHandler(this.textBoxProductName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Bill Id :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "Quantity :";
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Location = new System.Drawing.Point(276, 65);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(97, 15);
            this.CustomerName.TabIndex = 32;
            this.CustomerName.Text = "CustomerName :";
            // 
            // unitPrice
            // 
            this.unitPrice.AutoSize = true;
            this.unitPrice.Location = new System.Drawing.Point(387, 187);
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Size = new System.Drawing.Size(40, 15);
            this.unitPrice.TabIndex = 41;
            this.unitPrice.Text = ".. .. .. ..";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 15);
            this.label8.TabIndex = 41;
            this.label8.Text = "taka";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(583, 19);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(30, 15);
            this.Date.TabIndex = 42;
            this.Date.Text = "date";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(382, 65);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(140, 23);
            this.textBoxCustomerName.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(640, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 41;
            this.label6.Text = "..  ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(640, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 15);
            this.label7.TabIndex = 41;
            this.label7.Text = "..  ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(640, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 15);
            this.label9.TabIndex = 41;
            this.label9.Text = "..  ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(640, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 15);
            this.label10.TabIndex = 41;
            this.label10.Text = "..  ";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Silver;
            this.buttonClear.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonClear.Location = new System.Drawing.Point(663, 335);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(54, 65);
            this.buttonClear.TabIndex = 23;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // textBoxTotalItem
            // 
            this.textBoxTotalItem.Location = new System.Drawing.Point(314, 406);
            this.textBoxTotalItem.Name = "textBoxTotalItem";
            this.textBoxTotalItem.Size = new System.Drawing.Size(84, 23);
            this.textBoxTotalItem.TabIndex = 35;
            this.textBoxTotalItem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(248, 410);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 15);
            this.label11.TabIndex = 36;
            this.label11.Text = "Total Item :";
            // 
            // salesmanHomePage_productEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.unitPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.totalBill);
            this.Controls.Add(this.textBoxTotalItem);
            this.Controls.Add(this.textBoxTotalBill);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.textBoxBillid);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonAddProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "salesmanHomePage_productEntry";
            this.Text = "salesmanHomePage_productEntry";
            this.Load += new System.EventHandler(this.salesmanHomePage_productEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label totalBill;
        private TextBox textBoxTotalBill;
        private Label label3;
        private Label label1;
        private TextBox textBoxQuantity;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Button buttonPrint;
        private Button buttonAddProduct;
        private TextBox textBoxBillid;
        private TextBox textBoxProductName;
        private Label label4;
        private Label label5;
        private Label CustomerName;
        private Label unitPrice;
        private Label label8;
        private Label Date;
        private TextBox textBoxCustomerName;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label10;
        private Button buttonClear;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private TextBox textBoxTotalItem;
        private Label label11;
    }
}