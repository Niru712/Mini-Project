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

namespace ATM_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public static string AccNumber;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\kundan koli\source\repos\ATM Management\ATM Management\Atm management.mdf"";Integrated Security=True");
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTb1 where Accnum='" + AccNumTb.Text + "'and PIN = " + PinTb.Text + "", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString()=="1")
            {
                AccNumber=AccNumTb.Text; 
             HOME home = new HOME();
                home.Show();
                this.Hide();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Wrong Account Number Or Pin Code");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
