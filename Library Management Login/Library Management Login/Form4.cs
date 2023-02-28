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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9(); 
            f9.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          Form10 f10 = new Form10();  
          f10.Show();
          this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show();
            form13.button2_Click(null,null);
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Show();
            f14.button2_Click(null, null);
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            form15.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(); 
            f5.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BookStock1 bookstock1 = new BookStock1();
            bookstock1.Show();
            bookstock1.button2_Click(null, null);
            this.Hide();
        }
    }
}
