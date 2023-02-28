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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HKHCBLN;Initial Catalog=UserregistrationDB;Integrated Security=True");
        private void button4_Click(object sender, EventArgs e)
        {
            String AIUBid, password;
            AIUBid = textBox1.Text;
            password = textBox2.Text;

            try
            {
                String querry = "SELECT * FROM LibrarianSignUp WHERE AIUBId = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    AIUBid = textBox1.Text;
                    password = textBox2.Text;
                    Form12 f12 = new Form12();
                    f12.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login Details !!");
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
            catch
            {
                MessageBox.Show("");
            }
            finally
            {
                conn.Close();
            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(); 
            f1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form17 f17 = new Form17();  
            f17.Show();
            this.Hide();
        }
    }
}
