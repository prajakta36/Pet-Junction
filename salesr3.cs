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
    public partial class salesr3 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        public salesr3()
        {
            InitializeComponent();
        }

        private void salesr3_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-UR6PEC57\\SQLEXPRESS;Initial Catalog=iiht;Integrated Security=True");
            con.Open();
            string selectQuery = "select * from addimage4";

            cmd = new SqlCommand(selectQuery, con);
            da = new SqlDataAdapter(cmd);

            DataTable tab = new DataTable();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.RowTemplate.Height = 120;
            dataGridView1.AllowUserToAddRows = false;
            da.Fill(tab);
            dataGridView1.DataSource = tab;

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[0];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            da.Dispose();
        }
        public static DataGridViewRow selectedrow;
        private void button1_Click(object sender, EventArgs e)
        {
            dog_details d= new dog_details();   
            this.Hide();
            d.Show();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedrow = dataGridView1.Rows[e.RowIndex];
                buy3.buy21.ShowDialog();
            }
        }
    }
}
