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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class login2 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public login2()
        {
            InitializeComponent();
        }

        private void login2_Load(object sender, EventArgs e)
        {
            con= new SqlConnection("Data Source=LAPTOP-UR6PEC57\\SQLEXPRESS;Initial Catalog=iiht;Integrated Security=True");
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select empname, password  from emplyoee where empname='" + textBox1.Text + "' and password='" + textBox2.Text + "' ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Login Successfully");
                if (textBox1.Text == "praju" && textBox2.Text == "admin")
                {
                    adminpage r = new adminpage();
                    this.Hide();
                    r.Show();
                }

            }
            else
            {
                MessageBox.Show("Login Failed");
            }
            dr.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength >= 6)
            {
                errorProvider1.SetError(textBox2, "please enter value below 6 character");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form16 f = new Form16();
            this.Hide();
            f.Show();
        }
    }
}
