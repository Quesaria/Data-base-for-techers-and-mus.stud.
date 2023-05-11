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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "хасбикDataSet1.Таблица1". При необходимости она может быть перемещена или удалена.
            this.таблица1TableAdapter.Fill(this.хасбикDataSet1.Таблица1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true & radioButton1.Checked == true)
                таблица1BindingSource.Sort = "Фамилия ASC";
            if (checkBox2.Checked == true & radioButton1.Checked == true)
                таблица1BindingSource.Sort = "GPA ASC";
            if (checkBox3.Checked == true & radioButton1.Checked == true)
                таблица1BindingSource.Sort = "Факультет ASC";
            
            if (checkBox1.Checked == true & radioButton1.Checked == false)
                таблица1BindingSource.Sort = "Фамилия DESC";
            if (checkBox2.Checked == true & radioButton1.Checked == false)
                таблица1BindingSource.Sort = "GPA DESC";
            if (checkBox3.Checked == true & radioButton1.Checked == false)
                таблица1BindingSource.Sort = "Факультет DESC";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            таблица1BindingSource.Sort = null;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            таблица1BindingSource.Filter = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            таблица1BindingSource.Filter = "Имя LIKE'%" + textBox1.Text + "%'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            таблица1BindingSource.Filter = "GPA LIKE'%" + textBox2.Text + "%'";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            Hide();
        }
    }
}
