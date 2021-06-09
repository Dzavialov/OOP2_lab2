using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_ind_2
{
    public partial class Form1 : Form
    {
        delegate void dlg(object sender, EventArgs e);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Opacity == 0.5)
            {
                this.Opacity = 1;
            }

            else
            {
                this.Opacity = 0.5;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(this.BackColor == Color.Gray)
            {
                this.BackColor = Color.Yellow;
            }

            else
            {
                this.BackColor = Color.Gray;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hellow World");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я супермегакнопка,\nі цього мене не позбавиш!");
            dlg[] btn = new dlg[] { button1_Click, button2_Click, button3_Click };
            if (checkBox1.Checked == true)
            {
                btn[0](sender, e);
            }

            if(checkBox2.Checked == true)
            {
                btn[1](sender, e);
            }

            if(checkBox3.Checked == true)
            {
                btn[2](sender, e);
            }
        }
    }
}
