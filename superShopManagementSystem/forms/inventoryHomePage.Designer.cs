namespace superShopManagementSystem.forms
{
    partial class inventoryHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventoryHomePage));
            this.mainPanelManagerPage = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showStock = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanelManagerPage
            // 
            this.mainPanelManagerPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelManagerPage.Location = new System.Drawing.Point(149, 0);
            this.mainPanelManagerPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mainPanelManagerPage.Name = "mainPanelManagerPage";
            this.mainPanelManagerPage.Size = new System.Drawing.Size(710, 495);
            this.mainPanelManagerPage.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.showStock);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 495);
            this.panel1.TabIndex = 6;
            // 
            // showStock
            // 
            this.showStock.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.showStock.Location = new System.Drawing.Point(15, 224);
            this.showStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.showStock.Name = "showStock";
            this.showStock.Size = new System.Drawing.Size(112, 42);
            this.showStock.TabIndex = 6;
            this.showStock.Text = "Show stock";
            this.showStock.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 334);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.logout.Location = new System.Drawing.Point(15, 439);
            this.logout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(112, 35);
            this.logout.TabIndex = 4;
            this.logout.Text = "LOGOUT";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.search.Location = new System.Drawing.Point(15, 164);
            this.search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(112, 42);
            this.search.TabIndex = 3;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            // 
            // inventoryHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 495);
            this.Controls.Add(this.mainPanelManagerPage);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "inventoryHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inventoryHomePage";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel mainPanelManagerPage;
        private Panel panel1;
        private Button showStock;
        private PictureBox pictureBox1;
        private Button logout;
        private Button search;
    }
}