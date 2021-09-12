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
    public partial class ManageSellsForm : Form
    {
        DrinksRepo dr;
        SnacksRepo sk;
        public ManageSellsForm()
        {
            InitializeComponent();
          this.dr = new DrinksRepo();
            this. sk = new SnacksRepo();
        }

        private void DSellBtn_Click(object sender, EventArgs e)
        {
            List<Drinks> listofDrinks = dr.GetAllData();
            SellTable.DataSource = listofDrinks;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Snacks> listOfSnacks = sk.GetAllData();
            SellTable.DataSource = listOfSnacks;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* AdminHomepage p = new AdminHomepage(LoginForm l);
            this.Visible = false;
            p.Visible = true;*/
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Login l = new Login();
            AdminHomepage ah = new AdminHomepage(l);
            this.Visible = false;
            ah.Visible = true;
        }

       
    }
}
