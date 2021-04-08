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
    public partial class Form3 : Form
    {
        SqlConnection cnn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Mahynour\\Desktop\\bakery\\homepage\\homepage\\Database1.mdf;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string address = textBox2.Text;
            string orderName = comboBox1.Text;
            decimal quantity = numericUpDown1.Value;
            string orderType = comboBox2.Text;
            string phone = textBox3.Text;
            object[] args = new object[] { name, address, orderName, orderType, quantity, phone };
            string query = String.Format("insert into \"order\" (name, address, order_name, order_type, quantity, phone) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", args);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(query, cnn);
            int done = cmd.ExecuteNonQuery();
            if (done > 0)
            {
                this.Hide();
                MessageBox.Show("Thank you \n enjoy the order");
                cnn.Close();
            }
            else
            {
                MessageBox.Show("error");
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
