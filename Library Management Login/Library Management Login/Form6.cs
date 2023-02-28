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
   
    public partial class UserSignup : Form
    {

        public string Name, AIUBId, password, mail, Phonenumber, gender,address,birthdate, UserType = "";
        public UserSignup()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox13.Text.ToString() == this.textBox14.Text.ToString()) ;
            {
                String er;
                int flag = 0;
                UserControl1 userControl1 = new UserControl1();
                if (this.textBox3.Text != null)
                {
                    AIUBId = this.textBox3.Text.ToString();
                    if (AIUBId.Length != 10) { AIUBId = ""; MessageBox.Show("You have to give AIUB ID"); flag = 1; }
                }
                else
                {
                    MessageBox.Show("You have to give a valid AIUB ID");
                    flag = 1;
                }
                if (this.textBox1.Text != null) { Name = this.textBox1.Text.ToString(); }
                else
                {
                    MessageBox.Show("Enter Your Name");
                    flag |= 1;
                }
                if (this.textBox13.Text != null) { password = this.textBox14.Text.ToString(); }
                else
                {
                    MessageBox.Show("You have to give a valid password");
                    flag = 1;
                }
                if (this.textBox8.Text != null)
                {
                    mail = this.textBox8.Text.ToString();
                }
                else
                {
                    MessageBox.Show("Enter a valid Mail Address");
                    flag = 1;
                }
                if (this.textBox7.Text != null)
                {
                    Phonenumber = this.textBox7.Text.ToString();
                    if (Phonenumber.Length != 11) { Phonenumber = ""; flag |= 1; }
                }
                else
                {
                    MessageBox.Show("Enter a Valid Phone Number");
                    flag = 1;
                }
               if(this.textBox9.Text != null)
                {
                    address = this.textBox9.Text.ToString();    
               }
               else
                {
                   MessageBox.Show("Enter a Address");
                   flag = 1;
               }
                if (this.textBox6.Text != null)
                {
                    birthdate = this.textBox6.Text.ToString();
                }
                else
                {
                    MessageBox.Show("Enter Your Birth Date");
                    flag = 1;
                }
                if (radioButton1.Checked) { gender = "Male"; }
                else if (radioButton2.Checked) { gender = "Female"; }
                else { gender = "Other"; }
               
                
                try
                {
                    if (this.comboBox1.SelectedItem.ToString() == null)
                    {
                        MessageBox.Show("Please Select User Type");
                        flag = 1;
                    }
                    else { UserType = this.comboBox1.SelectedItem.ToString(); }
                }
                catch  (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (flag !=1)
                {
                    er = userControl1.create(AIUBId,Name,password, mail, Phonenumber, gender,address,birthdate, UserType);
                    MessageBox.Show(er);
                }
           

                
                }

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
