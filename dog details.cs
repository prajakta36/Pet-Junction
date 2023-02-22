using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    
    public partial class dog_details : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public dog_details()
        {
            InitializeComponent();
        }

        private void germToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addimage1 g= new addimage1();
            this.Hide();
            g.Show();

        }

        private void dog_details_Load(object sender, EventArgs e)
        {
            con= new SqlConnection("Data Source=LAPTOP-UR6PEC57\\SQLEXPRESS;Initial Catalog=iiht;Integrated Security=True");
            con.Open();
        }

        private void siberianHuskyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            slaesr1 s= new slaesr1();
            this.Hide();
            s.Show();
        }

        private void frenchBulldogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salesr2 f=new salesr2();
            this.Hide();
            f.Show();
        }

        private void americanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salesr3 f=new salesr3();
            this.Hide();
            f.Show();
        }

        private void puppiesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dogsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void americanEskimoDogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salesr4 d=new salesr4();   
            this.Hide();
            d.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form16 l=new Form16();
            this.Hide();
            l.Show();
        }
    }
}
