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
    public partial class adminpage : Form
    {
        public adminpage()
        {
            InitializeComponent();
        }

        private void adminpage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form16 l =new Form16
                ();
            this.Hide();
            l.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form16 l=new Form16();
            this.Show();
            l.Show();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userdetail d = new userdetail();
            this.Hide();
            d.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddImage a= new AddImage();
            this.Hide();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           salesreport s= new salesreport();    
            this.Hide();
            s.Show();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddImage2 a = new AddImage2();
            this.Hide();
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Addimage3 a = new Addimage3();
            this.Hide();
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addimage4 a = new addimage4();
            this.Hide();
            a.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           Addimage5 a = new Addimage5();
            this.Hide();
            a.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            slaesr1 s = new slaesr1();
            this.Hide();
            s.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            salesr2 s = new salesr2();
            this.Hide();
            s.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            salesr3 s = new salesr3();
            this.Hide();
            s.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            salesr4 s = new salesr4();
            this.Hide();
            s.Show();
        }
    }
}
