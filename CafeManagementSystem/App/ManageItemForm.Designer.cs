namespace App
{
    partial class ManageItemForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductNameTB = new System.Windows.Forms.TextBox();
            this.ProductPriceTB = new System.Windows.Forms.TextBox();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ViewAllBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchBoxTB = new System.Windows.Forms.TextBox();
            this.ItemTable = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductIdTB = new System.Windows.Forms.TextBox();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Price:";
            // 
            // ProductNameTB
            // 
            this.ProductNameTB.Location = new System.Drawing.Point(212, 95);
            this.ProductNameTB.Name = "ProductNameTB";
            this.ProductNameTB.Size = new System.Drawing.Size(100, 20);
            this.ProductNameTB.TabIndex = 2;
            // 
            // ProductPriceTB
            // 
            this.ProductPriceTB.Location = new System.Drawing.Point(212, 131);
            this.ProductPriceTB.Name = "ProductPriceTB";
            this.ProductPriceTB.Size = new System.Drawing.Size(100, 20);
            this.ProductPriceTB.TabIndex = 3;
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(131, 201);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(75, 23);
            this.AddProductBtn.TabIndex = 4;
            this.AddProductBtn.Text = "Add Product";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(237, 201);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 6;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ViewAllBtn
            // 
            this.ViewAllBtn.Location = new System.Drawing.Point(459, 52);
            this.ViewAllBtn.Name = "ViewAllBtn";
            this.ViewAllBtn.Size = new System.Drawing.Size(245, 23);
            this.ViewAllBtn.TabIndex = 7;
            this.ViewAllBtn.Text = "View All Product";
            this.ViewAllBtn.UseVisualStyleBackColor = true;
            this.ViewAllBtn.Click += new System.EventHandler(this.ViewAllBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Search:";
            // 
            // SearchBoxTB
            // 
            this.SearchBoxTB.Location = new System.Drawing.Point(489, 325);
            this.SearchBoxTB.Name = "SearchBoxTB";
            this.SearchBoxTB.Size = new System.Drawing.Size(226, 20);
            this.SearchBoxTB.TabIndex = 11;
            this.SearchBoxTB.TextChanged += new System.EventHandler(this.SearchBoxTB_TextChanged);
            // 
            // ItemTable
            // 
            this.ItemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemTable.Location = new System.Drawing.Point(391, 114);
            this.ItemTable.Name = "ItemTable";
            this.ItemTable.ReadOnly = true;
            this.ItemTable.Size = new System.Drawing.Size(366, 175);
            this.ItemTable.TabIndex = 23;
            this.ItemTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemTable_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Product Id:";
            // 
            // ProductIdTB
            // 
            this.ProductIdTB.Location = new System.Drawing.Point(212, 61);
            this.ProductIdTB.Name = "ProductIdTB";
            this.ProductIdTB.Size = new System.Drawing.Size(100, 20);
            this.ProductIdTB.TabIndex = 25;
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(193, 254);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadBtn.TabIndex = 26;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManageItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.ProductIdTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ItemTable);
            this.Controls.Add(this.SearchBoxTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ViewAllBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.ProductPriceTB);
            this.Controls.Add(this.ProductNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageItemForm";
            this.Text = "ManageItem";
            this.Load += new System.EventHandler(this.ManageItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductNameTB;
        private System.Windows.Forms.TextBox ProductPriceTB;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ViewAllBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchBoxTB;
        private System.Windows.Forms.DataGridView ItemTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductIdTB;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button button1;
    }
}