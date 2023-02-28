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
    public partial class Deleteuserform : Form
    {

        public Deleteuserform()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=DESKTOP-HKHCBLN;Initial Catalog=UserregistrationDB;Integrated Security=True;";
        DBAccess objdBAccess = new DBAccess();
        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Are You Sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                string query = "DELETE FROM SignUp WHERE AIUBId = '" + textBox1.Text + " ' ";
                SqlCommand deleteCommand = new SqlCommand(query);

                int row = objdBAccess.executeQuery(deleteCommand);
                if (row == 1)
                {
                    MessageBox.Show("Deleted Successfully");
                    button3_Click(null, null);

                }
                else
                {
                    MessageBox.Show("Error Occured");
                }
            }
        }

        public void button3_Click(object sender, EventArgs e)
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
