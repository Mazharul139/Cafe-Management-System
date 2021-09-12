using Entity1;
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
    public partial class AdminHomepage : Form
    {
        internal Login l;
        public AdminHomepage(Login l)
        {
            //InitializeComponent();
            InitializeComponent();
            this.l = l;
            WelcomeLabel.Text += l.Id;
        }

       

        private void ManageEmpBtn_Click(object sender, EventArgs e)
        {
            if (l.Role == 0)
            {
                ManageEmployee mef = new ManageEmployee(l);
                this.Visible = false;
                mef.Visible = true;
            }
            else
            {
                MessageBox.Show("Access Denied");
            }
        }
        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ManageProductBtn_Click(object sender, EventArgs e)
        {
            if (l.Role == 0)
            {
                ManageItemForm mif = new ManageItemForm();
                this.Visible = false;
                mif.Visible = true;
            }
            else
            {
                MessageBox.Show("Access Denied");
            }

        }

        private void ManageSalesBtn_Click(object sender, EventArgs e)
        {
            if (l.Role == 0)
            {
                ManageSellsForm msf = new ManageSellsForm();
                this.Visible = false;
                msf.Visible = true;
            }
            else
            {
                MessageBox.Show("Access Denied");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Visible = false;
            lf.Visible = true;
        }
       

       

        
    }
}
