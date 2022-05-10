namespace superShopManagementSystem.forms
{
    partial class adminHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminHomePage));
            this.mainPanelAdmin = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonISalesManager = new System.Windows.Forms.RadioButton();
            this.radioButtonInventoryManager = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.Button();
            this.deleteEntry = new System.Windows.Forms.Button();
            this.newEntry = new System.Windows.Forms.Button();
            this.checkList = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanelAdmin
            // 
            this.mainPanelAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelAdmin.Location = new System.Drawing.Point(176, 0);
            this.mainPanelAdmin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mainPanelAdmin.Name = "mainPanelAdmin";
            this.mainPanelAdmin.Size = new System.Drawing.Size(686, 493);
            this.mainPanelAdmin.TabIndex = 5;
            this.mainPanelAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanelAdmin_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButtonISalesManager);
            this.panel1.Controls.Add(this.radioButtonInventoryManager);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.deleteEntry);
            this.panel1.Controls.Add(this.newEntry);
            this.panel1.Controls.Add(this.checkList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 493);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "...";
            // 
            // radioButtonISalesManager
            // 
            this.radioButtonISalesManager.AutoSize = true;
            this.radioButtonISalesManager.Location = new System.Drawing.Point(24, 71);
            this.radioButtonISalesManager.Name = "radioButtonISalesManager";
            this.radioButtonISalesManager.Size = new System.Drawing.Size(97, 19);
            this.radioButtonISalesManager.TabIndex = 6;
            this.radioButtonISalesManager.TabStop = true;
            this.radioButtonISalesManager.Text = "salesManager";
            this.radioButtonISalesManager.UseVisualStyleBackColor = true;
            // 
            // radioButtonInventoryManager
            // 
            this.radioButtonInventoryManager.AutoSize = true;
            this.radioButtonInventoryManager.Location = new System.Drawing.Point(24, 46);
            this.radioButtonInventoryManager.Name = "radioButtonInventoryManager";
            this.radioButtonInventoryManager.Size = new System.Drawing.Size(122, 19);
            this.radioButtonInventoryManager.TabIndex = 5;
            this.radioButtonInventoryManager.TabStop = true;
            this.radioButtonInventoryManager.Text = "inventoryManager";
            this.radioButtonInventoryManager.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 305);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.logout.Location = new System.Drawing.Point(17, 433);
            this.logout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(112, 35);
            this.logout.TabIndex = 4;
            this.logout.Text = "LOGOUT";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // deleteEntry
            // 
            this.deleteEntry.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.deleteEntry.Location = new System.Drawing.Point(17, 224);
            this.deleteEntry.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deleteEntry.Name = "deleteEntry";
            this.deleteEntry.Size = new System.Drawing.Size(136, 41);
            this.deleteEntry.TabIndex = 3;
            this.deleteEntry.Text = "Delete entry";
            this.deleteEntry.UseVisualStyleBackColor = true;
            this.deleteEntry.Click += new System.EventHandler(this.deleteEntry_Click);
            // 
            // newEntry
            // 
            this.newEntry.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.newEntry.Location = new System.Drawing.Point(17, 106);
            this.newEntry.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newEntry.Name = "newEntry";
            this.newEntry.Size = new System.Drawing.Size(136, 41);
            this.newEntry.TabIndex = 2;
            this.newEntry.Text = "New entry";
            this.newEntry.UseVisualStyleBackColor = true;
            this.newEntry.Click += new System.EventHandler(this.newEntry_Click);
            // 
            // checkList
            // 
            this.checkList.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.checkList.Location = new System.Drawing.Point(17, 164);
            this.checkList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkList.Name = "checkList";
            this.checkList.Size = new System.Drawing.Size(136, 42);
            this.checkList.TabIndex = 1;
            this.checkList.Text = "CheckList";
            this.checkList.UseVisualStyleBackColor = true;
            this.checkList.Click += new System.EventHandler(this.checkList_Click);
            // 
            // adminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 493);
            this.Controls.Add(this.mainPanelAdmin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "adminHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminHomePage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel mainPanelAdmin;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button logout;
        private Button deleteEntry;
        private Button newEntry;
        private Button checkList;
        private RadioButton radioButtonISalesManager;
        private RadioButton radioButtonInventoryManager;
        private Label label1;
    }
}