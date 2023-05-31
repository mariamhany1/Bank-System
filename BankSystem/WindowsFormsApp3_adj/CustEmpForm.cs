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
    public partial class CustEmpForm : Form
    {
        public CustEmpForm()
        {
            InitializeComponent();
        }

        private void cUST_EMPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void CustEmpForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankSystemDataSet.CUST_EMP' table. You can move, or remove it, as needed.
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=MARIAM;Initial Catalog=Bank;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO CUST_EMP Values('" + eMPIDTextBox.Text + "', '" + cUST_SSNTextBox.Text + "')";
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
            sqlCommand.CommandText = "UPDATE CUST_EMP SET EMPID ='" + eMPIDTextBox.Text + "', CUST_SSN = '" + cUST_SSNTextBox.Text + "' WHERE  EMPID ='" + eMPIDTextBox.Text + "' AND CUST_SSN = '" + cUST_SSNTextBox.Text + "'";
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
            sqlCommand.CommandText = "DELETE FROM CUST_EMP WHERE EMPID = '" + eMPIDTextBox.Text + "' AND CUST_SSN = '" + cUST_SSNTextBox.Text + "' ";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Deletion was successfully completed");
        }

        private void eMPIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cUST_SSNTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void eMPIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void cUST_SSNLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.OpenForms[1].Show();
            this.Close();
        }
    }
}
