using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class MainForm : Form
    {
        public MainForm(object selectedItem)
        {
            InitializeComponent();
        }
        string username;
        public MainForm(string s)
        {
            InitializeComponent();
/*            username = s;*/
        }

        public MainForm()
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSystemDataSet.BRANCH' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'bankSystemDataSet.BANK' table. You can move, or remove it, as needed.
/*            if (username == "customer")
            {
                button1.Hide();
                button10.Hide();
                button5.Hide();
                button7.Hide();
            }
            if (username == "employee")
            {
                button1.Hide();
                button5.Hide();
                button7.Hide();
                button3.Hide();
                button9.Hide();
            }*/

        }







 

        private void button5_Click(object sender, EventArgs e)
        {
            CustEmpForm form2 = new CustEmpForm();
            form2.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AccountForm form2 = new AccountForm();
            form2.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BranchForm form2 = new BranchForm();
            form2.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CustomerForm form2 = new CustomerForm(username);
            form2.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CustPhoneNumberForm form2 = new CustPhoneNumberForm(username);
            form2.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            EmployeeForm form2 = new EmployeeForm(username);
            form2.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            LoanForm form2 = new LoanForm();
            form2.Show();
            this.Hide();
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BankForm f = new BankForm();
            f.Show();
            this.Hide();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoanForm loan = new LoanForm(username);
            loan.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}