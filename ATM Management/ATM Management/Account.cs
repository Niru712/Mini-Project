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

namespace ATM_Management
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
       // SqlConnection conn=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\kundan koli\source\repos\ATM Management\ATM Management\Atm management.mdf"";Integrated Security=True");

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\kundan koli\source\repos\ATM Management\ATM Management\Atm management.mdf"";Integrated Security=True");
            int bal = 0;
            if(AccNumtb.Text =="" || AccNumtb.Text == "" || Fnametb.Text == "" || Phonetb.Text =="" || Addresstb.Text =="" || Occupationtb.Text ==""|| Pintb.Text =="")
            {
                MessageBox.Show("Missing information");
            }else
            {
                try
                {
                    conn.Open();
                    string query = "insert into AccountTb1 values('" + AccNumtb.Text + "','" + Nametb.Text + "','" + Fnametb.Text + "','" + DOBscroll.Value.Date + "','" + Phonetb.Text + "','" + Addresstb.Text + "','" + Educationcb.SelectedItem.ToString() + "','" + Occupationtb.Text + "'," + Pintb.Text + ","+bal+")";
                    SqlCommand cmd = new SqlCommand(query,conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account created successfully");
                    conn.Close();
                    Login log= new Login();
                    log.Show();
                    this.Hide();
                }catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void label13_Click(object sender, EventArgs e) 
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }
    }
}
