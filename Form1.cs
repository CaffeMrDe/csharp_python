using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace csharp_python
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 100;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.ScrollToCaret();
            textBox2.Text = Convert.ToString(textBox1.TextLength);
        
            if (textBox1.TextLength >= textBox2.MaxLength)
            {
                string str = textBox1.Text.Substring(textBox2.MaxLength-50, textBox2.MaxLength-50);
                textBox1.Text = str;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (Char)(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "123\r\n";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
