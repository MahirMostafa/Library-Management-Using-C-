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
    public partial class Form17 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HKHCBLN;Initial Catalog=UserregistrationDB;Integrated Security=True");
        public Form17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string AIUBid;
            string Phonenumber;
            AIUBid = textBox1.Text;
            Phonenumber = textBox2.Text;

            try
            {
                String querry = "SELECT * FROM LibrarianSignUp WHERE AIUBId = '" + textBox1.Text + "' AND Phonenumber = '" + textBox2.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    AIUBid = textBox1.Text;
                    Phonenumber = textBox2.Text;
                    PassRecover3 passRecover3 = new PassRecover3();
                    passRecover3.Show();
                    passRecover3.button1_Click(null, null);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Details Or No Acoount Found !!");
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();  
            f11.Show();
            this.Close();
        }
    }
}
