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
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Addimage3 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        byte[] bytes;
        public Addimage3()
        {
            InitializeComponent();
        }

        private void Addimage3_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-UR6PEC57\\SQLEXPRESS;Initial Catalog=iiht;Integrated Security=True");
            con.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminpage a = new adminpage();
            this.Hide();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into addimage3(name,image,age,price) values(@name,@data,@age,@price)", con);
            cmd.Parameters.AddWithValue("@name", textBox3.Text);
            cmd.Parameters.AddWithValue("@data", bytes);
            cmd.Parameters.AddWithValue("@age", textBox1.Text);
            cmd.Parameters.AddWithValue("@price", textBox2.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("insert");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            string filename = openFileDialog1.FileName;
            bytes = File.ReadAllBytes(filename);
        }
    }
}
