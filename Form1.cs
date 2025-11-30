
using System;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || !dateTimePicker1.Checked)
            {
                MessageBox.Show("Zəhmət olmasa bütün xanaları doldurun.");
            }
            else
            {
                dataGridView1.Rows.Add(
                    textBox1.Text,
                    textBox2.Text,
                    dateTimePicker1.Value.ToShortDateString(),
                    false
                );

                textBox1.Clear();
                textBox2.Clear();
                dateTimePicker1.Checked = false;
            }
        }
    }
}
