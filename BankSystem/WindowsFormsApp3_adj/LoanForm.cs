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
    public partial class LoanForm : Form
    {
        public LoanForm()
        {
            InitializeComponent();
        }
        string username;
        public LoanForm(string s)
        {
            InitializeComponent();
            username = s;
        }

        private void lOANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void LoanForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSystemDataSet.LOAN' table. You can move, or remove it, as needed.
            if (username == "customer")
            {
                groupBox2.Hide();
            }
            if (username == "employee")
            {
                groupBox2.Hide();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=MARIAM;Initial Catalog=Bank;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO LOAN Values('" + lOANNUMTextBox.Text + "', '" + lOANBRANCHNUMTextBox.Text + "', '" + sSNTextBox.Text + "', '" + eMPIDTextBox.Text + "', '" + lOANTYPETextBox.Text + "', '" + lOANAMOUNTTextBox.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Insertion was successfully completed");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=MARIAM;Initial Catalog=Bank;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "UPDATE LOAN SET LOANBRANCHNUM ='" + lOANBRANCHNUMTextBox.Text + "', SSN = '" + sSNTextBox.Text + "', EMPID = '" + eMPIDTextBox.Text + "' , LOANTYPE = '" + lOANTYPETextBox.Text + "', LOANAMOUNT = '" + lOANAMOUNTTextBox.Text + "' WHERE LOANNUM = '" + lOANNUMTextBox.Text + "' ";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Update was successfully completed");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=MARIAM;Initial Catalog=Bank;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "DELETE FROM LOAN WHERE LOANNUM = '" + lOANAMOUNTTextBox.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Deletion was successfully completed");
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void lOANAMOUNTLabel_Click(object sender, EventArgs e)
        {

        }

        private void lOANTYPETextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.OpenForms[1].Show();
            this.Close();
        }
    }
}
