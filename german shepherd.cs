﻿using System;
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
    public partial class german_shepherd : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public german_shepherd()
        {
            InitializeComponent();
        }

        private void german_shepherd_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-UR6PEC57\\SQLEXPRESS;Initial Catalog=iiht;Integrated Security=True");
            con.Open();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dog_details dog= new dog_details();
            this.Hide();
            dog.Show();
        }
    }
}
