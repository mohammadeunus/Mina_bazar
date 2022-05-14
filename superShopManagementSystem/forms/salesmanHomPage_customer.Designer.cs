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
            this.textBoxAddcusotomer = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // sellerList
            // 
            this.sellerList.AutoSize = true;
            this.sellerList.Location = new System.Drawing.Point(538, 117);
            this.sellerList.Name = "sellerList";
            this.sellerList.Size = new System.Drawing.Size(80, 15);
            this.sellerList.TabIndex = 19;
            this.sellerList.Text = "Customer List";
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(68, 135);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(550, 245);
            this.dataGridView3.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Customer Name :";
            // 
            // textBoxAddcusotomer
            // 
            this.textBoxAddcusotomer.Location = new System.Drawing.Point(185, 71);
            this.textBoxAddcusotomer.Name = "textBoxAddcusotomer";
            this.textBoxAddcusotomer.Size = new System.Drawing.Size(140, 23);
            this.textBoxAddcusotomer.TabIndex = 21;
            this.textBoxAddcusotomer.TextChanged += new System.EventHandler(this.textBoxAddcusotomer_TextChanged);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(514, 21);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(30, 15);
            this.Date.TabIndex = 43;
            this.Date.Text = "date";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.errorLabel.Location = new System.Drawing.Point(68, 400);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(16, 15);
            this.errorLabel.TabIndex = 44;
            this.errorLabel.Text = "...";
            // 
            // salesmanHomPage_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(702, 441);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAddcusotomer);
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
        private TextBox textBoxAddcusotomer;
        private Label Date;
        private Label errorLabel;
    }
}