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
    public partial class ManageEmployee : Form
    {
        Login l;
        EmployeesRepo er;
        LoginRepo lr;
        public ManageEmployee(Login l)
        {
            InitializeComponent();
          //  InitializeComponent();
            this.er = new EmployeesRepo();
            this.l = l;
            this.lr = new LoginRepo();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ViewAllBtn_Click(object sender, EventArgs e)
        {
            List<Employees> listofEmployee = er.GetAllEmployees();
            EmployeeTable.DataSource = listofEmployee;
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            string empId = this.EmpIdTB.Text;
            Employees emp = er.GetEmployee(empId);

            if (emp == null)
            {
                MessageBox.Show("Invalid ID");
            }
            else
            {
                this.EmpNameTB.Text = emp.Name;
                this.EmpPhnNumberTB2.Text = emp.PhnNumber.Substring(4);
                this.EmpSalaryTB.Text = emp.Salary + "";
                this.EmpDesignationTB.Text = emp.Designation;

                this.RefreshBtn.Enabled = true;
                this.LoadBtn.Enabled = false;
                this.InsertBtn.Enabled = false;
                this.UpdateBtn.Enabled = true;
                this.DeleteBtn.Enabled = true;

                this.EmpIdTB.Enabled = false;
        
        }
        }
          private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            Login user = new Login();
            Employees emp = new Employees();

            int p = new Random().Next(99999999)+10000000;
            user.Id = this.EmpIdTB.Text;
            user.Password = p + "";

            emp.EmpId = this.EmpIdTB.Text;
            emp.Name = this.EmpNameTB.Text;
            try
            {
                int i = Convert.ToInt32(this.EmpPhnNumberTB2.Text);
                emp.PhnNumber = this.EmpPhnNumberTB1.Text + this.EmpPhnNumberTB2.Text;
                double sal = Convert.ToDouble(this.EmpSalaryTB.Text);
                emp.Salary = sal;
                emp.Designation = this.EmpDesignationTB.Text;

                if ((emp.Designation.ToLower()).Equals("manager"))
                {
                    user.Role = 0;
                }
               else
                {
                    user.Role = 1;
                }

                if (lr.InsertUser(user))
                {
                    if (er.InsertEmployee(emp))
                    {
                        MessageBox.Show("Employee Added with Id: "+user.Id+ " & Password: "+user.Password);
                        this.RefreshBtn_Click(sender, e);
                        this.ViewAllBtn_Click(sender, e);

                    }
                }
                else
                {
                    MessageBox.Show("Can Not Add"+ user.Id);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Invalid Data"+exp.StackTrace);
                
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            
            this.EmpIdTB.Text = "";
            this.EmpNameTB.Text = "";
            this.EmpPhnNumberTB2.Text = "";
            this.EmpSalaryTB.Text = "";
            this.EmpDesignationTB.Text = "";


            this.RefreshBtn.Enabled = false;
            this.LoadBtn.Enabled = true;
            this.InsertBtn.Enabled = true;
            this.UpdateBtn.Enabled = false;
            this.DeleteBtn.Enabled = false;
            
            this.EmpIdTB.Enabled = true;

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Login user = new Login();
            user.Id = this.EmpIdTB.Text;

            Employees emp = new Employees();
            emp.EmpId = this.EmpIdTB.Text;

            if (lr.DeleteUser(user))
            {
                if (er.DeleteEmployee(emp))
                {
                    MessageBox.Show("Employee Removed");
                    this.RefreshBtn_Click(sender, e);
                    this.ViewAllBtn_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Can Not Remove");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees();
            emp.EmpId = this.EmpIdTB.Text;
            emp.Name = this.EmpNameTB.Text;
            emp.PhnNumber = this.EmpPhnNumberTB1.Text + this.EmpPhnNumberTB2.Text;
            emp.Salary = Convert.ToDouble(this.EmpSalaryTB.Text);
            emp.Designation = this.EmpDesignationTB.Text;

            if (er.UpdateEmployee(emp))
            {
                MessageBox.Show("Updated");
                this.ViewAllBtn_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Can NOT Update");
            }
        }

        private void OnTableCellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchBoxValueChange_TextChanged(object sender, EventArgs e)
        {
            List<Employees> listOfEmployee = er.GetAllEmployees();
            String keyword = this.SearchBox.Text;
            List<Employees> searchedEmployee = listOfEmployee.FindAll(x => (x.EmpId.ToLower()).Contains(keyword.ToLower()) || (x.Name.ToLower()).Contains(keyword.ToLower()) || (x.PhnNumber.ToLower()).Contains(keyword.ToLower()) || (x.Designation.ToLower()).Contains(keyword.ToLower()));
            EmployeeTable.DataSource = searchedEmployee;
        }

        private void EmployeeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       




            }
}

       
    

