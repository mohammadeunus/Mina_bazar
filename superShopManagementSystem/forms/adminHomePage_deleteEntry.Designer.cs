namespace superShopManagementSystem.forms
{
    partial class adminHomePage_deleteEntry
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
            this.DeleteManagerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteIdBoxManager = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ERRORLABEL
            // 
            this.ERRORLABEL.AutoSize = true;
            this.ERRORLABEL.BackColor = System.Drawing.Color.IndianRed;
            this.ERRORLABEL.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ERRORLABEL.Location = new System.Drawing.Point(212, 321);
            this.ERRORLABEL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ERRORLABEL.Name = "ERRORLABEL";
            this.ERRORLABEL.Size = new System.Drawing.Size(0, 17);
            this.ERRORLABEL.TabIndex = 31;
            // 
            // DeleteManagerButton
            // 
            this.DeleteManagerButton.Font = new System.Drawing.Font("Segoe Script", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DeleteManagerButton.Location = new System.Drawing.Point(202, 254);
            this.DeleteManagerButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeleteManagerButton.Name = "DeleteManagerButton";
            this.DeleteManagerButton.Size = new System.Drawing.Size(282, 32);
            this.DeleteManagerButton.TabIndex = 30;
            this.DeleteManagerButton.Text = "delete user";
            this.DeleteManagerButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(199, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Manager id";
            // 
            // DeleteIdBoxManager
            // 
            this.DeleteIdBoxManager.Location = new System.Drawing.Point(307, 193);
            this.DeleteIdBoxManager.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeleteIdBoxManager.Name = "DeleteIdBoxManager";
            this.DeleteIdBoxManager.Size = new System.Drawing.Size(191, 23);
            this.DeleteIdBoxManager.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(197, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 27);
            this.label1.TabIndex = 27;
            this.label1.Text = "AdminPage: Delete a manager ";
            // 
            // adminHomePage_deleteEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.ERRORLABEL);
            this.Controls.Add(this.DeleteManagerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteIdBoxManager);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminHomePage_deleteEntry";
            this.Text = "adminHomePage_deleteEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ERRORLABEL;
        private Button DeleteManagerButton;
        private Label label2;
        private TextBox DeleteIdBoxManager;
        private Label label1;
    }
}