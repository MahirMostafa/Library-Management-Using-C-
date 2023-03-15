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
    public partial class BorrowBooks : Form
    {
        DBAccess objdBAccess = new DBAccess();
        string connectionString = @"Data Source=DESKTOP-HKHCBLN;Initial Catalog=UserregistrationDB;Integrated Security=True;";
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HKHCBLN;Initial Catalog=UserregistrationDB;Integrated Security=True");
        public BorrowBooks()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            string AIUBId=textBox5.Text;
            string BName =textBox2.Text ;
            string BId =textBox1.Text ;
            string Catagory = textBox3.Text;
            string Branch = textBox4.Text;
            string ReturnDate = dateTimePicker1.ToString();


            if(AIUBId.Equals(""))
            {
                MessageBox.Show("Please Enter User ID: ");
            }
            if (BId.Equals(""))
            {
                MessageBox.Show("Please Enter Book ID: ");
            }
            else if (BName.Equals(""))
            {
                MessageBox.Show("Please Enter Book Name ");
            }
            else if (Catagory.Equals(""))
            {
                MessageBox.Show("Please Select Catagory ");
            }
            else if (Branch.Equals(""))
            {
                MessageBox.Show("Please Select Branch ");
            }
            else if (ReturnDate.Equals(""))
            {
                MessageBox.Show("Please Select the Date ");
            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("INSERT INTO Cart(AIUBId,BId,BName,Catagory,Branch,ReturnDate) VALUES(@AIUBId,@BId,@BName,@Catagory,@Branch,@ReturnDate)");
                insertCommand.Parameters.AddWithValue("@AIUBId",AIUBId);
                insertCommand.Parameters.AddWithValue("@BId", BId);
                insertCommand.Parameters.AddWithValue("@BName", BName);
                insertCommand.Parameters.AddWithValue("@Catagory", Catagory);
                insertCommand.Parameters.AddWithValue("@Branch", Branch);
                insertCommand.Parameters.AddWithValue("@ReturnDate",ReturnDate );

                int row = objdBAccess.executeQuery(insertCommand);


                if (row == 1)
                {
                    MessageBox.Show("Book Added To Cart");


                }
                else
                {
                    MessageBox.Show("Error Occured");
                }


            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT BId,BName,Details,Catagory,Branch,quantity FROM Books", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT BName,Catagory,Branch FROM Books WHERE BId = '" +int.Parse(textBox1.Text)+"'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                textBox2.Text = dr.GetValue(0).ToString();
                textBox3.Text = dr.GetValue(1).ToString();
                textBox4.Text = dr.GetValue(2).ToString();
            }
            con.Close();
        }
    }
}
