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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 f1 = new Form9();
            f1.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 f3 = new Form10();
            f3.Show();
            Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
