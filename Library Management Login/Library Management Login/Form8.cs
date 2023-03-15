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
    public partial class Form8 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HKHCBLN;Initial Catalog=UserregistrationDB;Integrated Security=True");
        public Form8()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string AIUBid;
            string Phonenumber;
            AIUBid = textBox1.Text;
            Phonenumber = textBox2.Text;

            try
            {
                String querry = "SELECT * FROM AdminSignUp WHERE AIUBId = '" + textBox1.Text + "' AND Phonenumber = '" + textBox2.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    AIUBid = textBox1.Text;
                    Phonenumber = textBox2.Text;
                    PassRecover1 passRecover1 = new PassRecover1();
                    passRecover1.Show();
                    passRecover1.button1_Click(null, null);


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
            Form5 f5 = new Form5(); 
            f5.Show();
            this.Close();
        }
    }
}
