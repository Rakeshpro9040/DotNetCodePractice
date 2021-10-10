using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormPractice
{
    public partial class TestConnection : Form
    {
        public TestConnection()
        {
            InitializeComponent();
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        public string conString = "Data Source=LAPTOP-VFQ32EB0;Initial Catalog=ConnectionDb;Integrated Security=True";
        private void btnTest_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                String q = "Insert into Test(id, Name) values('"+txtId.Text.ToString()+"', '"+txtName.Text.ToString()+"')";
                SqlCommand cmd = new SqlCommand(q,con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Connection made Successfuly!");
            }
        }
    }
}
