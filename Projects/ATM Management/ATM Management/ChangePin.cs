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
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\kundan koli\source\repos\ATM Management\ATM Management\Atm management.mdf"";Integrated Security=True");
        string Acc = Login.AccNumber;
        private void ChangePinbtn_Click(object sender, EventArgs e)
        {
            if (Pin1Tb.Text == "" || Pin2Tb.Text == "")
            {
                MessageBox.Show("Enter and confirm the pin");
            }
            else if(Pin2Tb.Text != Pin1Tb.Text)
            {
                MessageBox.Show("Pin1 And Pin2 is not same");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "update AccountTb1 set PIN=" + Pin1Tb.Text + "Where Accnum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PIN Successfully Updated");
                    conn.Close();
                    Login home = new Login();
                    home.Show();
                    this.Hide();
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

        private void label13_Click(object sender, EventArgs e)
        {
            HOME home=new HOME();
            home.Show();    
            this.Hide();
        }
    }
}
