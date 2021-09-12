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
    public partial class EmployeeHomepage : Form
    {
        public EmployeeHomepage()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (Tea.Checked == true)
            {
                Tea.Enabled = true;

            }
            if (Tea.Checked == false)
            {
                Tea.Enabled = false;
                Tea.Text = "0";
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            BlackCoff.Text = "0";
            ColdCoff.Text = "0";
            TeaTB.Text = "0";
            CocaTB.Text = "0";
            SpriteTB.Text = "0";
            BbqTB.Text = "0";
            PizzaTB.Text = "0";
            SandwitchTB.Text = "0";
            CheeseTB.Text = "0";
            WingsTB.Text = "0";
            CostOfDrinksTB.Text = "0";
            CostOfSnacksTB.Text = "0";
            ServiceChargeTB.Text = "1.75";
        }

        private void EmployeeHomepage_Load(object sender, EventArgs e)
        {
            BlackCoff.Text = "0";
            ColdCoff.Text = "0";
            TeaTB.Text = "0";
            CocaTB.Text = "0";
            SpriteTB.Text = "0";
            BbqTB.Text = "0";
            PizzaTB.Text = "0";
            SandwitchTB.Text = "0";
            CheeseTB.Text = "0";
            WingsTB.Text = "0";
            CostOfDrinksTB.Text = "0";
            CostOfSnacksTB.Text = "0";
            ServiceChargeTB.Text = "1.75";

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BlackCof_CheckedChanged(object sender, EventArgs e)
        {
            if (BlackCof.Checked == true)
            {
                BlackCoff.Enabled = true;
 
            }
            if (BlackCof.Checked == false)
            {
                BlackCoff.Enabled = false;
                BlackCoff.Text = "0";
            }
        }

        private void BlackCoff_TextChanged(object sender, EventArgs e)
        {
            BlackCoff.Text = "";
            BlackCoff.Focus();
        }

        private void ColdCof_CheckedChanged(object sender, EventArgs e)
        {
            if (ColdCof.Checked == true)
            {
                ColdCoff.Enabled = true;

            }
            if (ColdCof.Checked == false)
            {
                ColdCoff.Enabled = false;
                ColdCoff.Text = "0";
            }

        }

       

       
    }
}
