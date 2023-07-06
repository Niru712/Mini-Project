using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Management
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\kundan koli\source\repos\ATM Management\ATM Management\Atm management.mdf"";Integrated Security=True");
        string Acc = Login.AccNumber;

        private void addtransaction()
        {
            string TrType = "Deposit";
            try
            {
                conn.Open();
                string query = "insert into TransactionTb1 values('" + Acc + "','" + TrType + "'," + DepoAmtTb.Text + ",'" +DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
               // MessageBox.Show("Account created successfully");
                conn.Close();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\kundan koli\source\repos\ATM Management\ATM Management\Atm management.mdf"";Integrated Security=True");
            if(DepoAmtTb.Text=="" || Convert.ToInt32(DepoAmtTb.Text)<=0)
            {
                MessageBox.Show("Enter the amount of Deposit");
            }
            else
            {
                //string Acc = Login.AccNumber;
                newbalance = oldbalance + Convert.ToInt32(DepoAmtTb.Text);
                try
                {
                    conn.Open();
                    string query = "update AccountTb1 set Balance=" + newbalance + "Where Accnum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deposit Successful");
                    conn.Close();
                    addtransaction();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            HOME home =new HOME();
            home.Show();
            this.Hide();
        }
        int oldbalance,newbalance;
         private void getbalance()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select balance from AccountTb1 where Accnum='" + Acc+ "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldbalance = Convert.ToInt32( dt.Rows[0][0].ToString());
            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {

        }
    }
}
