using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class buy1 : Form

    {
         SqlConnection con;
        SqlCommand cmd;

        public static buy1 buy;
        public static buy1 buy2
        {
            get
            {
                if (buy == null)
                {
                    buy = new buy1();
                }
                return buy;
            }
        }
        public buy1()
        {
            InitializeComponent();
        }

        private void buy1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-UR6PEC57\\SQLEXPRESS;Initial Catalog=iiht;Integrated Security=True");
            con.Open();
            textBox3.Text = slaesr1.selectedrow.Cells[1].Value.ToString();
            textBox1.Text = slaesr1.selectedrow.Cells[2].Value.ToString();
            textBox5.Text = slaesr1.selectedrow.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into buy values('" + textBox5.Text + "', '" + textBox3.Text + "'," + textBox1.Text + "," + textBox4.Text + "," + textBox2.Text + ")", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("order confirmed");
            Form16 f = new Form16();
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dog_details d = new dog_details();
            this.Hide();
            d.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox4.Text);
            c = a * b;
            textBox2.Text = c.ToString();
        }
    }
}
