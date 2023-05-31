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
    public partial class CustPhoneNumberForm : Form
    {
        public CustPhoneNumberForm()
        {
            InitializeComponent();
        }
        string username;
        public CustPhoneNumberForm(string s)
        {
            InitializeComponent();
            username = s;
        }

        private void cUSTOMER_PHONENUMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void CustPhoneNumberForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSystemDataSet.CUSTOMER_PHONENUM' table. You can move, or remove it, as needed.
            if (username == "customer")
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
            sqlCommand.CommandText = "INSERT INTO CUSTOMER_PHONENUM Values('" + sSNTextBox.Text + "', '" + pHONENUMBERTextBox.Text + "', '" + cUST_SSNTextBox.Text + "')";
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
            sqlCommand.CommandText = "UPDATE CUSTOMER_PHONENUM SET SSN ='" + sSNTextBox.Text + "', PHONENUMBER = '" + pHONENUMBERTextBox.Text + "', CUST_SSN = '" + cUST_SSNTextBox.Text + "' WHERE  SSN ='" + sSNTextBox.Text + "' AND PHONENUMBER = '" + pHONENUMBERTextBox.Text + "' AND CUST_SSN = '" + cUST_SSNTextBox.Text + "'";
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
            sqlCommand.CommandText = "DELETE FROM CUSTOMER_PHONENUM WHERE SSN = '" + sSNTextBox.Text + "' PHONENUMBER = '" + pHONENUMBERTextBox.Text + "' AND CUST_SSN = '" + cUST_SSNTextBox.Text + "' ";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Deletion was successfully completed");
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.OpenForms[1].Show();
            this.Close();
        }
    }
}
