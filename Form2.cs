using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_Car_Form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        internal string SettextBox1
        {
            set{textBox1.Text = value;}
        }
        internal string SettextBox2
        {
            set { textBox2.Text = value; }
        }
        internal string SettextBox3
        {
            set { textBox3.Text = value; }
        }
        internal string SettextBox4
        {
            set { textBox4.Text = value; }
        }
        internal string SettextBox5
        {
            set { textBox5.Text = value; }
        }
        internal string SettextBox6
        {
            set { textBox6.Text = value; }
        }
        internal string SettextBox7
        {
            set { textBox7.Text = value; }
        }
        internal string SettextBox8
        {
            set { textBox8.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
