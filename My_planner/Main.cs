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
using System.IO;

namespace My_planner
{
    public partial class Main : Form
    {
        SqlConnection con = new SqlConnection("Data Source=Shehan-PC;Initial Catalog=Myplanner;Integrated Security=True");
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void myProfile1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Login f1 = new Login();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myProfile1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personal_Now1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            future_travel1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            now_travel1.BringToFront();
        }

        private void now_travel1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            personalFuture1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nowStudies1.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            futureStudies1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            finance1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nowFinance1.BringToFront();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string st = Login.passingtext;
            con.Open();
            SqlCommand cmd = new SqlCommand("select FirstName,Image from Login where Username='" + st + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                String a = (dr["FirstName"].ToString());
                btnname.Text = a;
                //image load
                byte[] images = ((byte[])dr[1]);
                if (images == null)
                {
                    pictureBox1.Image = null;
                }
                else
                {
                    MemoryStream mstreem = new MemoryStream(images);
                    pictureBox1.Image = Image.FromStream(mstreem);
                }
            }
            else
            {
                MessageBox.Show("Not avilable picture of you...");
            }
            con.Close();

        }
    }
}
