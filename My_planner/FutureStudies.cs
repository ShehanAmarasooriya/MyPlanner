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

namespace My_planner
{
    public partial class FutureStudies : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=Shehan-PC;Initial Catalog=Myplanner;Integrated Security=True");
        string st = Login.passingtext;
        int rownum = 0;
        public FutureStudies()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FutureStudies_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from FutureSt where Username='" + st + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                lblcountry.Text = (dr["Country"].ToString());
                lblIns.Text = (dr["Ins"].ToString());
                lblExanName.Text = (dr["Exam"].ToString());
                lblDuration.Text = (dr["Durartion"].ToString());
                lblcost.Text = (dr["Cost"].ToString());
                lblstartdate.Text= (dr["Start"].ToString());
            }
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FutureSt Ft = new FutureSt();
            Ft.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string st = Login.passingtext;
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from FutureSt where Username='" + st + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            rownum--;
            if (rownum < 1)
            {
                lblcountry.Text = (dt.Rows[rownum]["Country"].ToString());
                lblIns.Text = (dt.Rows[rownum]["Ins"].ToString());
                lblExanName.Text = (dt.Rows[rownum]["Exam"].ToString());
                lblDuration.Text = (dt.Rows[rownum]["Durartion"].ToString());
                lblcost.Text = (dt.Rows[rownum]["Cost"].ToString());
                lblstartdate.Text = (dt.Rows[rownum]["Start"].ToString());



            }
            con.Close();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string st = Login.passingtext;
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from FutureSt where Username='" + st + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            rownum++;
            if (rownum < dt.Rows.Count)
            {

                lblcountry.Text = (dt.Rows[rownum]["Country"].ToString());
                lblIns.Text = (dt.Rows[rownum]["Ins"].ToString());
                lblExanName.Text = (dt.Rows[rownum]["Exam"].ToString());
                lblDuration.Text = (dt.Rows[rownum]["Durartion"].ToString());
                lblcost.Text = (dt.Rows[rownum]["Cost"].ToString());
                lblstartdate.Text = (dt.Rows[rownum]["Start"].ToString());


               

            }
            con.Close();
        }
    }
}
