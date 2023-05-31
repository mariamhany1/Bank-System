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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        string username;
        public CustomerForm(string s)
        {
            InitializeComponent();
            username = s;
        }

        private void cUSTOMERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cUSTOMERBindingSource.EndEdit();

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

            if(username == "customer")
            {
                button1.Hide();
                button3.Hide();
                groupBox2.Hide();
            }

        }

        private void lOANDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=MARIAM;Initial Catalog=Bank;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO CUSTOMER Values('" + sSNTextBox.Text + "', '" + cUSTBRANCHNUMTextBox.Text + "', '" + fNAMETextBox.Text + "', '" + lNAMETextBox.Text + "', '" + cOUNTRYTextBox.Text + "', '"+ zIPCODETextBox.Text + "', '" + sTREETTextBox.Text + "', '" + bUILDINGNUMTextBox.Text + "')";
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
            sqlCommand.CommandText = "UPDATE CUSTOMER SET FNAME = '" + fNAMETextBox.Text + "', LNAME = '" + lNAMETextBox.Text + "' , COUNTRY = '" + cOUNTRYTextBox.Text + "', ZIPCODE = '" + zIPCODETextBox.Text + "', STREET = '" + sTREETTextBox.Text + "', BUILDINGNUM = '" + bUILDINGNUMTextBox.Text + "' WHERE SSN = '" + sSNTextBox.Text + "' ";
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
            sqlCommand.CommandText = "DELETE FROM CUSTOMER WHERE SSN = '" + sSNTextBox.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Deletion was successfully completed");
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
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

        private void cUSTOMERBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}

