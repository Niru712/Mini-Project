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
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\kundan koli\source\repos\ATM Management\ATM Management\Atm management.mdf"";Integrated Security=True");
        private void getbalance()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select balance from AccountTb1 where Accnum='"+AccNumberlbl.Text+"'",conn);
            DataTable dt=new DataTable();
            sda.Fill(dt);
            Balancelbl.Text = "Rs "+dt.Rows[0][0].ToString();
            conn.Close();
        }
        private void Balance_Load(object sender, EventArgs e)
        {
            AccNumberlbl.Text = HOME.AccNumber;
            getbalance();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            HOME home =new HOME();
            this.Hide();
            home.Show();
        }

        private void AccNumberlbl_Click(object sender, EventArgs e)
        {

        }

        private void Balancelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
