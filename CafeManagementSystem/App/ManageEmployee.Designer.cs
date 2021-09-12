namespace App
{
    partial class ManageEmployee
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
            this.button2 = new System.Windows.Forms.Button();
            this.ViewAllBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EmpIdTB = new System.Windows.Forms.TextBox();
            this.EmpNameTB = new System.Windows.Forms.TextBox();
            this.EmpSalaryTB = new System.Windows.Forms.TextBox();
            this.EmpPhnNumberTB2 = new System.Windows.Forms.TextBox();
            this.EmpDesignationTB = new System.Windows.Forms.TextBox();
            this.EmpPhnNumberTB1 = new System.Windows.Forms.TextBox();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.EmployeeTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(664, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "LogOut";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ViewAllBtn
            // 
            this.ViewAllBtn.Location = new System.Drawing.Point(439, 83);
            this.ViewAllBtn.Name = "ViewAllBtn";
            this.ViewAllBtn.Size = new System.Drawing.Size(284, 23);
            this.ViewAllBtn.TabIndex = 2;
            this.ViewAllBtn.Text = "View All Employees";
            this.ViewAllBtn.UseVisualStyleBackColor = true;
            this.ViewAllBtn.Click += new System.EventHandler(this.ViewAllBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(119, 83);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(247, 23);
            this.RefreshBtn.TabIndex = 3;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Employee ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Employee Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Employee Phn Number :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Employee Salary :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Employee Designation :";
            // 
            // EmpIdTB
            // 
            this.EmpIdTB.Location = new System.Drawing.Point(224, 129);
            this.EmpIdTB.Name = "EmpIdTB";
            this.EmpIdTB.Size = new System.Drawing.Size(151, 20);
            this.EmpIdTB.TabIndex = 9;
            // 
            // EmpNameTB
            // 
            this.EmpNameTB.Location = new System.Drawing.Point(224, 176);
            this.EmpNameTB.Name = "EmpNameTB";
            this.EmpNameTB.Size = new System.Drawing.Size(151, 20);
            this.EmpNameTB.TabIndex = 10;
            // 
            // EmpSalaryTB
            // 
            this.EmpSalaryTB.Location = new System.Drawing.Point(224, 260);
            this.EmpSalaryTB.Name = "EmpSalaryTB";
            this.EmpSalaryTB.Size = new System.Drawing.Size(151, 20);
            this.EmpSalaryTB.TabIndex = 11;
            // 
            // EmpPhnNumberTB2
            // 
            this.EmpPhnNumberTB2.Location = new System.Drawing.Point(275, 219);
            this.EmpPhnNumberTB2.Name = "EmpPhnNumberTB2";
            this.EmpPhnNumberTB2.Size = new System.Drawing.Size(100, 20);
            this.EmpPhnNumberTB2.TabIndex = 12;
            // 
            // EmpDesignationTB
            // 
            this.EmpDesignationTB.Location = new System.Drawing.Point(224, 303);
            this.EmpDesignationTB.Name = "EmpDesignationTB";
            this.EmpDesignationTB.Size = new System.Drawing.Size(151, 20);
            this.EmpDesignationTB.TabIndex = 13;
            // 
            // EmpPhnNumberTB1
            // 
            this.EmpPhnNumberTB1.Location = new System.Drawing.Point(224, 219);
            this.EmpPhnNumberTB1.Name = "EmpPhnNumberTB1";
            this.EmpPhnNumberTB1.Size = new System.Drawing.Size(47, 20);
            this.EmpPhnNumberTB1.TabIndex = 15;
            this.EmpPhnNumberTB1.Text = "+880";
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(65, 359);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadBtn.TabIndex = 16;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.Location = new System.Drawing.Point(160, 359);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(75, 23);
            this.InsertBtn.TabIndex = 17;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(259, 359);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 18;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(350, 359);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 19;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Seach Here:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(549, 352);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(190, 20);
            this.SearchBox.TabIndex = 21;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBoxValueChange_TextChanged);
            // 
            // EmployeeTable
            // 
            this.EmployeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeTable.Location = new System.Drawing.Point(406, 133);
            this.EmployeeTable.Name = "EmployeeTable";
            this.EmployeeTable.ReadOnly = true;
            this.EmployeeTable.Size = new System.Drawing.Size(366, 175);
            this.EmployeeTable.TabIndex = 22;
            this.EmployeeTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeTable_CellContentClick);
            // 
            // ManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.EmployeeTable);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.EmpPhnNumberTB1);
            this.Controls.Add(this.EmpDesignationTB);
            this.Controls.Add(this.EmpPhnNumberTB2);
            this.Controls.Add(this.EmpSalaryTB);
            this.Controls.Add(this.EmpNameTB);
            this.Controls.Add(this.EmpIdTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.ViewAllBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ManageEmployee";
            this.Text = "ManageEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ViewAllBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmpIdTB;
        private System.Windows.Forms.TextBox EmpNameTB;
        private System.Windows.Forms.TextBox EmpSalaryTB;
        private System.Windows.Forms.TextBox EmpPhnNumberTB2;
        private System.Windows.Forms.TextBox EmpDesignationTB;
        private System.Windows.Forms.TextBox EmpPhnNumberTB1;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.DataGridView EmployeeTable;
    }
}