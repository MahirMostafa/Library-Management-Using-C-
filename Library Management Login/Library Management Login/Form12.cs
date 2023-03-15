using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_Login
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       // private void button8_Click(object sender, EventArgs e)
      //  {
       ///    Form11 form11 = new Form11();
        //   form11.Show();
         //   this.Close();
       // }

        private void button7_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.Show();
            f16.button2_Click(null, null);
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Deleteuserform f17 =new Deleteuserform();
            f17.Show();
            f17.button3_Click(null, null);
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bookstock bookstock = new Bookstock();
            bookstock.Show();
            bookstock.button2_Click(null,null);

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addbook addbook =new Addbook();
            addbook.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteBooks deleteBooks =new DeleteBooks();
            deleteBooks.Show();
            deleteBooks.button3_Click(null, null);
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookStatus2 bookstatus2 =new BookStatus2();
            bookstatus2.Show();
            bookstatus2.button2_Click(null, null);
            this.Hide();
        }
    }
}
