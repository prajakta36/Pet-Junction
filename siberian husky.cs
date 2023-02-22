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
    public partial class siberian_husky : Form
    {
        public siberian_husky()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dog_details dog= new dog_details();
            this.Hide();
            dog.Show();
        }

        private void siberian_husky_Load(object sender, EventArgs e)
        {

        }
    }
}
