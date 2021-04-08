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


namespace homepage
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mahynour\Desktop\bakery\homepage\homepage\Database2.mdf;Integrated Security=True");
            SqlCommand comm = new SqlCommand(@"insert into [dbo].[feedback] ([feedback]) values ('"+ richTextBox1.Text + "')", conc);
            conc.Open();
            comm.ExecuteNonQuery();
            conc.Close();
            this.Hide();
            MessageBox.Show("we'll see it soon!");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
