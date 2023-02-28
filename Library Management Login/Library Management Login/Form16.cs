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


namespace Library_Management_Login
{
    public partial class Form16 : Form
    {
        string connectionString = @"Data Source=DESKTOP-HKHCBLN;Initial Catalog=UserregistrationDB;Integrated Security=True;";
        public Form16()
        {
            InitializeComponent();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT AIUBId,Name,mail,Phonenumber,gender,address,birthdate,UserType FROM SignUp", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Close();
        }
    }
}
