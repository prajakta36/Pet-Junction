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
    public partial class userdetail : Form
    {
        public userdetail()
        {
            InitializeComponent();
        }

        private void userdetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iihtDataSet6.registration' table. You can move, or remove it, as needed.
            this.registrationTableAdapter1.Fill(this.iihtDataSet6.registration);
            // TODO: This line of code loads data into the 'iihtDataSet5.registration' table. You can move, or remove it, as needed.
            this.registrationTableAdapter.Fill(this.iihtDataSet5.registration);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminpage l=new adminpage();
            this.Hide();
            l.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

