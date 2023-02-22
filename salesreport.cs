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
    public partial class salesreport : Form
    {
        public salesreport()
        {
            InitializeComponent();
        }

        private void salesreport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iihtDataSet7.buy' table. You can move, or remove it, as needed.
            this.buyTableAdapter.Fill(this.iihtDataSet7.buy);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminpage a = new adminpage();
            this.Hide();
            a.Show();   
        }
    }
}
