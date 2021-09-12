namespace App
{
    partial class AdminHomepage
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
            this.button1 = new System.Windows.Forms.Button();
            this.ManageEmpBtn = new System.Windows.Forms.Button();
            this.ManageProductBtn = new System.Windows.Forms.Button();
            this.ViewReportBtn = new System.Windows.Forms.Button();
            this.ManageSalesBtn = new System.Windows.Forms.Button();
            this.ChangePasswordBtn = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManageEmpBtn
            // 
            this.ManageEmpBtn.Location = new System.Drawing.Point(45, 152);
            this.ManageEmpBtn.Name = "ManageEmpBtn";
            this.ManageEmpBtn.Size = new System.Drawing.Size(106, 52);
            this.ManageEmpBtn.TabIndex = 2;
            this.ManageEmpBtn.Text = "Manage Employee";
            this.ManageEmpBtn.UseVisualStyleBackColor = true;
            this.ManageEmpBtn.Click += new System.EventHandler(this.ManageEmpBtn_Click);
            // 
            // ManageProductBtn
            // 
            this.ManageProductBtn.Location = new System.Drawing.Point(195, 152);
            this.ManageProductBtn.Name = "ManageProductBtn";
            this.ManageProductBtn.Size = new System.Drawing.Size(106, 52);
            this.ManageProductBtn.TabIndex = 3;
            this.ManageProductBtn.Text = "Manage Product";
            this.ManageProductBtn.UseVisualStyleBackColor = true;
            this.ManageProductBtn.Click += new System.EventHandler(this.ManageProductBtn_Click);
            // 
            // ViewReportBtn
            // 
            this.ViewReportBtn.Location = new System.Drawing.Point(497, 152);
            this.ViewReportBtn.Name = "ViewReportBtn";
            this.ViewReportBtn.Size = new System.Drawing.Size(106, 52);
            this.ViewReportBtn.TabIndex = 4;
            this.ViewReportBtn.Text = "View Report";
            this.ViewReportBtn.UseVisualStyleBackColor = true;
            // 
            // ManageSalesBtn
            // 
            this.ManageSalesBtn.Location = new System.Drawing.Point(345, 152);
            this.ManageSalesBtn.Name = "ManageSalesBtn";
            this.ManageSalesBtn.Size = new System.Drawing.Size(106, 52);
            this.ManageSalesBtn.TabIndex = 5;
            this.ManageSalesBtn.Text = "Manage Sales";
            this.ManageSalesBtn.UseVisualStyleBackColor = true;
            this.ManageSalesBtn.Click += new System.EventHandler(this.ManageSalesBtn_Click);
            // 
            // ChangePasswordBtn
            // 
            this.ChangePasswordBtn.Location = new System.Drawing.Point(637, 152);
            this.ChangePasswordBtn.Name = "ChangePasswordBtn";
            this.ChangePasswordBtn.Size = new System.Drawing.Size(106, 52);
            this.ChangePasswordBtn.TabIndex = 6;
            this.ChangePasswordBtn.Text = "Change Password";
            this.ChangePasswordBtn.UseVisualStyleBackColor = true;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(192, 54);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(55, 13);
            this.WelcomeLabel.TabIndex = 7;
            this.WelcomeLabel.Text = "Welcome ";
            // 
            // AdminHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.ChangePasswordBtn);
            this.Controls.Add(this.ManageSalesBtn);
            this.Controls.Add(this.ViewReportBtn);
            this.Controls.Add(this.ManageProductBtn);
            this.Controls.Add(this.ManageEmpBtn);
            this.Controls.Add(this.button1);
            this.Name = "AdminHomepage";
            this.Text = "AdminHomepage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ManageEmpBtn;
        private System.Windows.Forms.Button ManageProductBtn;
        private System.Windows.Forms.Button ViewReportBtn;
        private System.Windows.Forms.Button ManageSalesBtn;
        private System.Windows.Forms.Button ChangePasswordBtn;
        private System.Windows.Forms.Label WelcomeLabel;
    }
}