using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace центр_дополнительного_образования
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                this.Hide();
                var admin = new admin();
                admin.Show();
            }

            else if (textBox1.Text == "prepod" && textBox2.Text == "prepod")
            {
                this.Hide();
                var prepod = new prepod();
                prepod.Show();
            }

            else
            {
                MessageBox.Show("Ошибка доступа");
            }
        }
    }
}
