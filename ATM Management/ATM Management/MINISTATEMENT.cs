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
    public partial class MINISTATEMENT : Form
    {
        public MINISTATEMENT()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\kundan koli\source\repos\ATM Management\ATM Management\Atm management.mdf"";Integrated Security=True");
        string Acc = Login.AccNumber;
      
        
       // private static DataTable DataSource;   //field of data source
        //public static DataTable Datasource { get; private set; } //property datasource

        private void populate()
        {
            conn.Open();
            string query = "select * from TransactionTb1 where AccNum='"+Acc+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query,conn);
            SqlCommandBuilder builder= new SqlCommandBuilder(sda);
            var ds=new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void MINISTATEMENT_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            this.Hide();
            home.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            populate();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
