using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;




namespace WindowsFormsApp3
{
    public partial class Exceute_SQLQueryFromTextbox : Form
    {

        SqlConnection con = new SqlConnection(Properties.Settings.Default.BankSystemConnectionString);
        SqlDataAdapter da;
        DataSet ds;


        public Exceute_SQLQueryFromTextbox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = txtquery.Text;
            da = new SqlDataAdapter(query, con);
            ds = new DataSet();
            da.Fill(ds);
            con.Close();
            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            if (ds.Tables[1].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[1];
            }
            if (ds.Tables[2].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[2];
            }
            if (ds.Tables[3].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[3];
            }
            if (ds.Tables[4].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[2];
            }
            if (ds.Tables[5].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[2];
            }
            if (ds.Tables[6].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[2];
            }
            if (ds.Tables[7].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[2];
            }
        }

        private void Exceute_SQLQueryFromTextbox_Load(object sender, EventArgs e)
        {

        }

        private void txtquery_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
