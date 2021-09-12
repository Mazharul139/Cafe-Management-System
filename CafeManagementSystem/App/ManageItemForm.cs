using Entity1;
using Repository2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class ManageItemForm : Form
    {
        DatabaseConnectionClass dcc;
        //internal Login l;
        ManageItemRepo mir;
        LoginRepo lr;
        public ManageItemForm()
        {
            InitializeComponent();
            this.mir= new ManageItemRepo();
            this.lr = new LoginRepo();
            dcc = new DatabaseConnectionClass();
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            ManageItems mi = new ManageItems();
            mi.ItemId = this.ProductIdTB.Text;
            mi.ItemName = this.ProductNameTB.Text;
            //mi.ItemPrice = Convert.ToString(ProductPriceTB.Text);
            try
            {
                double price = Convert.ToDouble(this.ProductPriceTB.Text);
                mi.ItemPrice = price;
                if (mir.InsertProduct(mi))
                {
                    MessageBox.Show("Item Added with Id: " + mi.ItemId + " & Price: " + mi.ItemPrice);
                    // this.RefreshBtn_Click(sender, e);
                    //this.ViewAllBtn_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Can Not Add : " + mi.ItemId);
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show("Invalid Data" + exp.StackTrace);

            }
            finally
            {
                dcc.CloseConnection();
            }

 
        }
        

        private void ManageItemForm_Load(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //Login user = new Login();
           // user.Id = this.EmpIdTB.Text;

            ManageItems mi = new ManageItems();
            mi.ItemId = this.ProductIdTB.Text;

            //if (lr.DeleteUser(user))
            //{
            try
            {
                if (mir.DeleteProduct(mi))
                {
                    MessageBox.Show("Item Removed");
                    // this.RefreshBtn_Click(sender, e);
                  //  this.ViewAllBtn_Click(sender, e);
                }
                // }
                else
                {
                    MessageBox.Show("Can Not Remove");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Invalid Data" + exp.StackTrace);

            }
        }

        private void ViewAllBtn_Click(object sender, EventArgs e)
        {
            List<ManageItems> listofItems = mir.GetAllItems();
            ItemTable.DataSource = listofItems;
        }

        private void ItemTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchBoxTB_TextChanged(object sender, EventArgs e)
        {
            List<ManageItems> listOfItems = mir.GetAllItems();
            String keyword = this.SearchBoxTB.Text;
            List<ManageItems> searchedItem = listOfItems.FindAll(x => (x.ItemId.ToLower()).Contains(keyword.ToLower()) || (x.ItemName.ToLower()).Contains(keyword.ToLower()));
            ItemTable.DataSource = searchedItem;
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            string id = this.ProductIdTB.Text;
            ManageItems mi = mir.GetItem(id);

            if (mi == null)
            {
                MessageBox.Show("Invalid ID");
            }
            else
            {
                this.ProductIdTB.Text = mi.ItemId;
                this.ProductNameTB.Text = mi.ItemName;
                double pri = Convert.ToDouble(ProductPriceTB.Text);
                mi.ItemPrice = pri;
               // this.ProductPriceTB.Text = mi.ItemPrice ;
              //  this.EmpDesignationTB.Text = emp.Designation;

               // this.RefreshBtn.Enabled = true;
                this.LoadBtn.Enabled = false;
               // this.InsertBtn.Enabled = false;
                //his.UpdateBtn.Enabled = true;
                //this.DeleteBtn.Enabled = true;

                //his.EmpIdTB.Enabled = false;
            }

        }
        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            AdminHomepage ah = new AdminHomepage(l);
            this.Visible = false;
            ah.Visible = true;
        }

       


      
    }
}
