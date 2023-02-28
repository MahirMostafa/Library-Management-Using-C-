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
    public partial class Addbook : Form
    {
         DBAccess objdBAccess = new DBAccess();
        string connectionString = @"Data Source=DESKTOP-HKHCBLN;Initial Catalog=UserregistrationDB;Integrated Security=True;";
        public Addbook()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string BName = textBox1.Text;  
            string Details = textBox2.Text; 
            string Catagory = comboBox1.Text;
            string Branch = comboBox2.Text;
            string quantity = textBox3.Text;
            if(BName.Equals(""))
            {
                MessageBox.Show("Please Enter BookName ");
            }
            else if (Details.Equals(""))
            {
                MessageBox.Show("Please Enter The Details ");
            }
           else if (Catagory.Equals(""))
            {
                MessageBox.Show("Please Select Catagory ");
            }
           else if (Branch.Equals(""))
            {
                MessageBox.Show("Please Select Branch ");
            }
           else if (quantity.Equals(""))
            {
                MessageBox.Show("Please Enter Quantity ");
            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("INSERT INTO bOOKS(BName,Details,Catagory,Branch,quantity) VALUES(@BName,@Details,@Catagory,@Branch,@quantity)");
                insertCommand.Parameters.AddWithValue("@BName",BName);
                insertCommand.Parameters.AddWithValue("@Details", Details);
                insertCommand.Parameters.AddWithValue("@Catagory", Catagory);
                insertCommand.Parameters.AddWithValue("@Branch", Branch);
                insertCommand.Parameters.AddWithValue("@quantity", quantity);

                int row = objdBAccess.executeQuery(insertCommand);


                if(row == 1)
                {
                    MessageBox.Show("Book Added");
                    button3_Click(null,null);


                }
                else
                {
                    MessageBox.Show("Error Occured");
                }
              

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT BName,Details,Catagory,Branch,quantity FROM Books", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;


            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
