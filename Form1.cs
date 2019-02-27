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

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source = LAPTOP - RHC58KDI; Initial Catalog = Data; User ID = sa; Password = P@55w0rd;");
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from LOGIN where Username = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                this.Hide();
                Main SS = new Main();
                SS.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.");
            }
        }
    }
}
