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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                double a = -10, b = 10, h = 0.1, x, y;
                this.chart1.Series[0].Points.Clear();
                x = a;
                while (x <= b)
                {
                    y = Math.Sin(x);
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x += h;
                }
            }
            else if (radioButton2.Checked)
            {
                double a = -20, b = 10, h = 0.2, x, y;
                this.chart1.Series[0].Points.Clear();
                x = a;
                while (x <= b)
                {
                    y = Math.Sin(x);
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x += h;
                }
            }
            else if (radioButton3.Checked)
            {
                double a = -5, b = 5, h = 0.5, x, y;
                this.chart1.Series[0].Points.Clear();
                x = a;
                while (x <= b)
                {
                    y = Math.Sin(x);
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x += h;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            Hide();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
