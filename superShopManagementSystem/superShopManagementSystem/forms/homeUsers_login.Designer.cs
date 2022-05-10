namespace superShopManagementSystem.forms
{
    partial class homeUsers_login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeUsers_login));
            this.login = new System.Windows.Forms.Button();
            this.userPassTextBox = new System.Windows.Forms.TextBox();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.userId = new System.Windows.Forms.Label();
            this.userPass = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminLoginInfo = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login.Location = new System.Drawing.Point(304, 333);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(193, 34);
            this.login.TabIndex = 0;
            this.login.Text = "login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.button1_Click);
            // 
            // userPassTextBox
            // 
            this.userPassTextBox.Location = new System.Drawing.Point(372, 280);
            this.userPassTextBox.Name = "userPassTextBox";
            this.userPassTextBox.Size = new System.Drawing.Size(125, 23);
            this.userPassTextBox.TabIndex = 2;
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Location = new System.Drawing.Point(372, 251);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(125, 23);
            this.userIdTextBox.TabIndex = 3;
            // 
            // userId
            // 
            this.userId.AutoSize = true;
            this.userId.Location = new System.Drawing.Point(304, 251);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(38, 15);
            this.userId.TabIndex = 4;
            this.userId.Text = "label4";
            // 
            // userPass
            // 
            this.userPass.AutoSize = true;
            this.userPass.Location = new System.Drawing.Point(304, 283);
            this.userPass.Name = "userPass";
            this.userPass.Size = new System.Drawing.Size(38, 15);
            this.userPass.TabIndex = 27;
            this.userPass.Text = "label6";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(304, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // adminLoginInfo
            // 
            this.adminLoginInfo.AutoSize = true;
            this.adminLoginInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.adminLoginInfo.Location = new System.Drawing.Point(0, 435);
            this.adminLoginInfo.Name = "adminLoginInfo";
            this.adminLoginInfo.Size = new System.Drawing.Size(38, 15);
            this.adminLoginInfo.TabIndex = 29;
            this.adminLoginInfo.Text = "label1";
            this.adminLoginInfo.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Admin.png");
            this.imageList1.Images.SetKeyName(1, "inventory.png");
            this.imageList1.Images.SetKeyName(2, "salesManager.png");
            // 
            // homeUsers_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminLoginInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userPass);
            this.Controls.Add(this.userId);
            this.Controls.Add(this.userIdTextBox);
            this.Controls.Add(this.userPassTextBox);
            this.Controls.Add(this.login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "homeUsers_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "homeUsers_login";
            this.Load += new System.EventHandler(this.homeUsers_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button login;
        private Label adminLoginInfo;
        private TextBox userPassTextBox;
        private TextBox userIdTextBox;
        private Label label2;
        private Label label3;
        private Label userId;
        private Label userPass;
        private PictureBox pictureBox1;
        private ImageList imageList1;
    }
}