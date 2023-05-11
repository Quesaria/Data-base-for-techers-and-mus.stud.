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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\laptop\Downloads\zvuk-notyi-do.wav");
            player.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\laptop\Downloads\zvuk-notyi-re.wav");
            player.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\laptop\Downloads\zvuk-notyi-mi.wav");
            player.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\laptop\Downloads\zvuk-notyi-fa.wav");
            player.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\laptop\Downloads\zvuk-notyi-sol.wav‪");
            player.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\laptop\Downloads\zvuk-notyi-lya.wav‪");
            player.Play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\laptop\Downloads\zvuk-notyi-si.wav‪");
            player.Play();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            Hide();
        }
    }
}
