using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class stationery : Form
    {
        public stationery()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {   int a=comboBox1.SelectedIndex;
            if(a==0)
            {
                textBox1.Text = "10";
            }
            else if (a == 1)
            {
                textBox1.Text = "5";
            }
             else if (a == 2)
            {
                textBox1.Text = "100";
            }
            else if (a == 3)
            {
                textBox1.Text = "2";
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a=int.Parse(textBox1.Text);
            b=int.Parse(textBox2.Text);
            c = a * b;
            textBox3.Text=c.ToString();
        }
    }
}
