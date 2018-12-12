using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "akash" && textBox2.Text == "password")
            {
                MessageBox.Show("Logged in successfully");
                this.Hide();
                Form2 f = new Form2();
                f.Show();
            }
            else
            {
                MessageBox.Show("invalid username or password");
                textBox1.Clear();
                textBox2.Clear();
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
