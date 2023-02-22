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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class AddImage : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        byte[] bytes;
        

        public AddImage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminpage a = new adminpage();
            this.Hide();
            a.Show();
                 
        }

        private void AddImage_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-UR6PEC57\\SQLEXPRESS;Initial Catalog=iiht;Integrated Security=True");
            con.Open(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into addimage1(name,image,age,price) values(@name,@data,@age,@price)", con);
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
            bytes=File.ReadAllBytes(filename);    
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete from addimage1 where id=" + textBox4.Text + "", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data deleted");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            cmd = new SqlCommand("update addimage1 set name='"+textBox3.Text+"',age='"+textBox1.Text+"',price="+textBox2.Text+" where id="+textBox4.Text+" ", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data updated successfully ");
            
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
