using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace My_planner
{
    public partial class now_travel : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=Shehan-PC;Initial Catalog=Myplanner;Integrated Security=True");
        int rownum = 0;
        public now_travel()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Travelled_where TW = new Travelled_where();
            TW.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewTravelles NT = new NewTravelles();
            NT.Show();
        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void now_travel_Load(object sender, EventArgs e)
        {
            string st = Login.passingtext;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from NowTravel where Username='" + st + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
             
                richTextBox1.Text = (dr["Description"].ToString());
                lblname.Text=(dr["Place"].ToString());
                //image load
                byte[] images = ((byte[])dr[2]);
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

            con.Close();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string st = Login.passingtext;
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from NowTravel where Username='" + st + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            rownum++;
            if (rownum < dt.Rows.Count)
            {

                richTextBox1.Text = (dt.Rows[rownum]["Description"].ToString());
                lblname.Text = (dt.Rows[rownum]["Place"].ToString());
                //image loadr
                byte[] images = ((byte[])dt.Rows[rownum][2]);
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
            con.Close();



        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string st = Login.passingtext;
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from NowTravel where Username='" + st + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            rownum--;
            if (rownum < 1)
            {

                richTextBox1.Text = (dt.Rows[rownum]["Description"].ToString());
                lblname.Text = (dt.Rows[rownum]["Place"].ToString());
                //image loadr
                byte[] images = ((byte[])dt.Rows[rownum][2]);
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
            con.Close();

        }
    }
}
