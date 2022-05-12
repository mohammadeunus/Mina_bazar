namespace superShopManagementSystem.forms
{
    partial class salesmanHomPage_customer
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
            this.sellerList = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAddcusotomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // sellerList
            // 
            this.sellerList.AutoSize = true;
            this.sellerList.Location = new System.Drawing.Point(290, 149);
            this.sellerList.Name = "sellerList";
            this.sellerList.Size = new System.Drawing.Size(80, 15);
            this.sellerList.TabIndex = 19;
            this.sellerList.Text = "Customer List";
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(68, 176);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(550, 204);
            this.dataGridView3.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Customer Name :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(254, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 23);
            this.textBox1.TabIndex = 21;
            // 
            // buttonAddcusotomer
            // 
            this.buttonAddcusotomer.BackColor = System.Drawing.Color.Silver;
            this.buttonAddcusotomer.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonAddcusotomer.Location = new System.Drawing.Point(417, 74);
            this.buttonAddcusotomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddcusotomer.Name = "buttonAddcusotomer";
            this.buttonAddcusotomer.Size = new System.Drawing.Size(127, 33);
            this.buttonAddcusotomer.TabIndex = 20;
            this.buttonAddcusotomer.Text = "Add Customer";
            this.buttonAddcusotomer.UseVisualStyleBackColor = false;
            this.buttonAddcusotomer.Click += new System.EventHandler(this.buttonAddcusotomer_Click);
            // 
            // salesmanHomPage_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(702, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonAddcusotomer);
            this.Controls.Add(this.sellerList);
            this.Controls.Add(this.dataGridView3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "salesmanHomPage_customer";
            this.Text = "salesmanHomPage_customer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label sellerList;
        private DataGridView dataGridView3;
        private Label label1;
        private TextBox textBox1;
        private Button buttonAddcusotomer;
    }
}