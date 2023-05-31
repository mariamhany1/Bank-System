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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }



        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=MARIAM;Initial Catalog=Bank;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOGIN WHERE username ='"+ textBox1.Text+ "' AND password = '" + textBox2.Text + "'", sqlConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string cmbItemValue = comboBox1.SelectedItem.ToString();
            if(dt.Rows.Count>0)
            {
                for(int i = 0; i<dt.Rows.Count; i++)
                {
                    if(dt.Rows[i]["usertype"].ToString() == cmbItemValue)
                    {
                        MessageBox.Show("You are logged in as " + dt.Rows[i][2]);
                        if(comboBox1.SelectedIndex == 0)
                        {
                            MainForm f1 = new MainForm(comboBox1.Text);
                            f1.Show();
                            this.Hide();
                        }
                        else if(comboBox1.SelectedIndex == 1)
                        {
                            MainForm f1=new MainForm(comboBox1.Text);
                            f1.Show();
                            this.Hide();
                        }
                        if (comboBox1.SelectedIndex == 2)
                        {
                            MainForm f1 = new MainForm(comboBox1.Text);
                            f1.Show();
                            this.Hide();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInForm registration = new SignInForm();
            registration.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
