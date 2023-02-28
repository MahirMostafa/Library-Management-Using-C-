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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BorrowBooks borrowBooks = new BorrowBooks();
            borrowBooks.Show();
            borrowBooks.button2_Click(null,null);
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            BookCart1 cart1 = new BookCart1();
            cart1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(); 
            f3.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReturnBook book = new ReturnBook();
            book.Show();
            book.button2_Click(null, null);
            this.Hide();
        }
    }
}
