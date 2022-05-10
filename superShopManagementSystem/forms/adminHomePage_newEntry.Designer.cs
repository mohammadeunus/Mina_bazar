namespace superShopManagementSystem.forms
{
    partial class adminHomePage_newEntry
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
            this.ERRORLABEL = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EntryIdManager = new System.Windows.Forms.TextBox();
            this.EntryPassBoxManager = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ERRORLABEL
            // 
            this.ERRORLABEL.AutoSize = true;
            this.ERRORLABEL.BackColor = System.Drawing.Color.IndianRed;
            this.ERRORLABEL.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ERRORLABEL.Location = new System.Drawing.Point(252, 325);
            this.ERRORLABEL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ERRORLABEL.Name = "ERRORLABEL";
            this.ERRORLABEL.Size = new System.Drawing.Size(0, 17);
            this.ERRORLABEL.TabIndex = 27;
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Segoe Script", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.createButton.Location = new System.Drawing.Point(255, 256);
            this.createButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(282, 32);
            this.createButton.TabIndex = 26;
            this.createButton.Text = "create";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(252, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(252, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Manager id";
            // 
            // EntryIdManager
            // 
            this.EntryIdManager.Location = new System.Drawing.Point(360, 169);
            this.EntryIdManager.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EntryIdManager.Name = "EntryIdManager";
            this.EntryIdManager.Size = new System.Drawing.Size(191, 23);
            this.EntryIdManager.TabIndex = 23;
            // 
            // EntryPassBoxManager
            // 
            this.EntryPassBoxManager.Location = new System.Drawing.Point(360, 204);
            this.EntryPassBoxManager.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EntryPassBoxManager.Name = "EntryPassBoxManager";
            this.EntryPassBoxManager.PasswordChar = 'x';
            this.EntryPassBoxManager.Size = new System.Drawing.Size(191, 23);
            this.EntryPassBoxManager.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(250, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 27);
            this.label1.TabIndex = 21;
            this.label1.Text = "AdminPage: Manager New Entry";
            // 
            // adminHomePage_newEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ERRORLABEL);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EntryIdManager);
            this.Controls.Add(this.EntryPassBoxManager);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminHomePage_newEntry";
            this.Text = "adminHomePage_newEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ERRORLABEL;
        private Button createButton;
        private Label label3;
        private Label label2;
        private TextBox EntryIdManager;
        private TextBox EntryPassBoxManager;
        private Label label1;
    }
}