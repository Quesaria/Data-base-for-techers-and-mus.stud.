using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ma_way
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                ToolTip firstTool = new ToolTip();
                firstTool.AutoPopDelay = 9000;
                firstTool.InitialDelay = 500;
                firstTool.ReshowDelay = 500;
                firstTool.ShowAlways = true;
                firstTool.SetToolTip(this.textBox1, "Insert Login");
            }
        }
                private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "User1" && textBox2.Text == "qwerty" && radioButton1.Checked)
            {
                Form2 f = new Form2();
                f.Show();
                Hide();

            }
            else if (textBox1.Text == "User1" && textBox2.Text == "qwerty" && radioButton2.Checked)
            {
                Form6 f = new Form6();
                f.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Try again");
            }
        }

    }
}


 

        
   

