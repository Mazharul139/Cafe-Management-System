using Repository2;

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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            LoginRepo lr = new LoginRepo();
            string id = UserTB.Text;
            string password = PassTB.Text;

           Login l = lr.GetUser(id, password);

            if (l != null)
            {
                if (l.Role == 0)
                { //MessageBox.Show("Valid");
                    AdminHomepage hp = new AdminHomepage(l);
                    this.Visible = false;
                    hp.Visible = true;
                }
               if(l.Role==1) {
                    EmployeeHomepage ep = new EmployeeHomepage();
                    this.Visible = false;
                    ep.Visible = true;
 
                }
            }
            else
            {
                MessageBox.Show("Invalid User");
            }
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        

       
    }
}
