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
    public partial class american_eskimo_dog : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public american_eskimo_dog()
        {
            InitializeComponent();
        }

        private void american_eskimo_dog_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-UR6PEC57\\SQLEXPRESS;Initial Catalog=iiht;Integrated Security=True");
            con.Open();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dog_details d=new dog_details();
            this.Hide();
            d.Show();   
        }
    }
}
