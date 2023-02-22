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


namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select username , password from registration where username='" + textBox4.Text + "' and password='" + textBox5.Text + "' ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("user login successfully");
                dog_details d = new dog_details();
                this.Hide();
                d.Show();
            }
            else
            {
                MessageBox.Show("login failed");
            }
            dr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            this.Hide();
            r.Show();
        }

        private void login_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-UR6PEC57\\SQLEXPRESS;Initial Catalog=iiht;Integrated Security=True");
            con.Open();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.TextLength >= 6)
            {
                errorProvider1.SetError(textBox5, "please enter value below 6 character");

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form16 f =new Form16();
            this.Hide();
            f.Show();
        }
    }
}
