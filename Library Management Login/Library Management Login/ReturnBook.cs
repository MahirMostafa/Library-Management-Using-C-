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
    public partial class ReturnBook : Form
    {
        DBAccess objdBAccess = new DBAccess();
        string connectionString = @"Data Source=DESKTOP-HKHCBLN;Initial Catalog=UserregistrationDB;Integrated Security=True;";
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string AIUBId = textBox1.Text;
            string BId = textBox2.Text;

            if (AIUBId.Equals(""))
            {
                MessageBox.Show("Please Enter Your Id ");
            }
            else if (BId.Equals(""))
            {
                MessageBox.Show("Please Enter Your Book Id ");
            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("INSERT INTO UList(AIUBId,BId) VALUES(@AIUBId,@BId)");
                insertCommand.Parameters.AddWithValue("@AIUBId", AIUBId);
                insertCommand.Parameters.AddWithValue("@BId", BId);

                int row = objdBAccess.executeQuery(insertCommand);


                if (row == 1)
                {
                    MessageBox.Show("Rturned The Book To the Librarian");
                    button2_Click(null, null);


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
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT AIUBId,BId FROM UList", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
        }
    }
}
