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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Registration : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public Registration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form16 obj= new Form16();
            this.Hide();    
            obj.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into registration values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "'," + textBox4.Text + ")", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data submited successfully");
           login obj=new login(); 
            this.Hide();
            obj.Show();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-UR6PEC57\\SQLEXPRESS;Initial Catalog=iiht;Integrated Security=True");
            con.Open();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength >= 6)
            {
                errorProvider1.SetError(textBox2, "please enter value below 6 character");

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.TextLength >=10)
            {
                errorProvider1.SetError(textBox4, "please enter value below 10 character");

            }
        }
    }
}
