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
    public partial class BookStatus2 : Form
    {
        string connectionString = @"Data Source=DESKTOP-HKHCBLN;Initial Catalog=UserregistrationDB;Integrated Security=True;";
        DBAccess objdBAccess = new DBAccess();
        public BookStatus2()
        {
            InitializeComponent();
        }

     
        public void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT BId,AIUBId, BName,Catagory,Branch,ReturnDate FROM Cart", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;

            }
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT AIUBId,BId FROM UList", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView2.DataSource = dtbl;

            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("User Returned the Book ?", "Remove User From The Cart", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                string query = "DELETE FROM Cart WHERE AIUBId = '" + textBox1.Text + " '  AND BId = '" + textBox2.Text + "' ";
                button4_Click(null, null);
                SqlCommand deleteCommand = new SqlCommand(query);
                
                int row = objdBAccess.executeQuery(deleteCommand);
                if (row == 1)
                {
                    MessageBox.Show("User Removed From The Cart");
                    //button4_Click(null,null);
                    button2_Click(null, null);

                }
                else
                {
                    MessageBox.Show("Error Occured");
                }
            }
                
        
       
        }

        private void button4_Click(object sender, EventArgs e)
        {

           // DialogResult dialog = MessageBox.Show("User Returned the Book ?", "Remove User From The Cart", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
           // if (dialog == DialogResult.Yes)
           // {
                string query = "DELETE FROM UList WHERE AIUBId = '" + textBox1.Text + " '  AND BId = '" + textBox2.Text + "' ";

                SqlCommand deleteCommand = new SqlCommand(query);

                int row = objdBAccess.executeQuery(deleteCommand);
                if (row == 1)
                {
                    //MessageBox.Show("User Removed From The Cart");
                    button2_Click(null, null);

                }
                else
                {
                    MessageBox.Show("Error Occured");
                }
           // }

        }
    }
}
