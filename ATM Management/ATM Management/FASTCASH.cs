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
    public partial class FASTCASH : Form
    {
        public FASTCASH()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
            {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }
        private void FASTCASH_Load(object sender, EventArgs e)
        {
            getbalance();
        }

        // int amt1=100,amt2=500,amt3=1000,amt4=2000,amt5=5000,amt6=10000;
        private void addtransaction1()

        {
            string TrType = "WithDraw";
            try
            {
                conn.Open();
                string query = "insert into TransactionTb1 values('" + Acc + "','" + TrType + "'," + 100 + ",'" + DateTime.Today.Date.ToString() + "')";
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
        private void addtransaction2()

        {
            string TrType = "WithDraw";
            try
            {
                conn.Open();
                string query = "insert into TransactionTb1 values('" + Acc + "','" + TrType + "'," + 500 + ",'" + DateTime.Today.Date.ToString() + "')";
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
        private void addtransaction3()

        {
            string TrType = "WithDraw";
            try
            {
                conn.Open();
                string query = "insert into TransactionTb1 values('" + Acc + "','" + TrType + "'," + 1000 + ",'" + DateTime.Today.Date.ToString() + "')";
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
        private void addtransaction4()

        {
            string TrType = "WithDraw";
            try
            {
                conn.Open();
                string query = "insert into TransactionTb1 values('" + Acc + "','" + TrType + "'," + 2000 + ",'" + DateTime.Today.Date.ToString() + "')";
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
        private void addtransaction5()

        {
            string TrType = "WithDraw";
            try
            {
                conn.Open();
                string query = "insert into TransactionTb1 values('" + Acc + "','" + TrType + "'," + 5000 + ",'" + DateTime.Today.Date.ToString() + "')";
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
        private void addtransaction6()

        {
            string TrType = "WithDraw";
            try
            {
                conn.Open();
                string query = "insert into TransactionTb1 values('" + Acc + "','" + TrType + "'," + 10000 + ",'" + DateTime.Today.Date.ToString() + "')";
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
            if(bal<100)
            {
                MessageBox.Show("Balance cannot be negative");
            }
            else
            {
               int newbalance = bal - 100;
                try
                {
                    conn.Open();
                    string query = "update AccountTb1 set Balance=" + newbalance + "Where Accnum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw Successful");
                    conn.Close();
                    addtransaction1();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //fast cash
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\kundan koli\source\repos\ATM Management\ATM Management\Atm management.mdf"";Integrated Security=True");
        string Acc = Login.AccNumber;
        int bal;
        private void getbalance()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select balance from AccountTb1 where Accnum='" + Acc + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            balancelbl.Text = " Balance Rs " + dt.Rows[0][0].ToString();
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (bal < 500)
            {
                MessageBox.Show("Balance cannot be negative");
            }
            else
            {
                int newbalance = bal - 500;
                try
                {
                    conn.Open();
                    string query = "update AccountTb1 set Balance=" + newbalance + "Where Accnum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw Successful");
                    conn.Close();
                    addtransaction2();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (bal < 1000)
            {
                MessageBox.Show("Balance cannot be negative");
            }
            else
            {
                int newbalance = bal - 1000;
                try
                {
                    conn.Open();
                    string query = "update AccountTb1 set Balance=" + newbalance + "Where Accnum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw Successful");
                    conn.Close();
                    addtransaction3();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (bal < 2000)
            {
                MessageBox.Show("Balance cannot be negative");
            }
            else
            {
                int newbalance = bal - 2000;
                try
                {
                    conn.Open();
                    string query = "update AccountTb1 set Balance=" + newbalance + "Where Accnum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw Successful");
                    conn.Close();
                    addtransaction4();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (bal < 5000)
            {
                MessageBox.Show("Balance cannot be negative");
            }
            else
            {
                int newbalance = bal - 5000;
                try
                {
                    conn.Open();
                    string query = "update AccountTb1 set Balance=" + newbalance + "Where Accnum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw Successful");
                    conn.Close();
                    addtransaction5();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (bal < 10000)
            {
                MessageBox.Show("Balance cannot be negative");
            }
            else
            {
                int newbalance = bal - 10000;
                try
                {
                    conn.Open();
                    string query = "update AccountTb1 set Balance=" + newbalance + "Where Accnum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw Successful");
                    conn.Close();
                    addtransaction6();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
