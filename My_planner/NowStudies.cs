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
    public partial class NowStudies : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=Shehan-PC;Initial Catalog=Myplanner;Integrated Security=True");
        string st = Login.passingtext;
        int rownum = 0;
        public NowStudies()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DoneStudies Ds = new DoneStudies();
            Ds.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NowStudies_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from NowStudy where Username='" + st + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                String a = (dr["Levels"].ToString());
                String b = (dr["Institute"].ToString());
                String c = (dr["ExamName"].ToString());
                String d = (dr["Achievements"].ToString());


                txtlevel.Text = a;
                txtIns.Text = b;
                txtExam.Text = c;
                txtachi.Text = d;
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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

                txtlevel.Text = (dt.Rows[rownum]["Levels"].ToString());
                txtIns.Text = (dt.Rows[rownum]["Institute"].ToString());
                txtExam.Text = (dt.Rows[rownum]["ExamName"].ToString());
                txtachi.Text = (dt.Rows[rownum]["Achievements"].ToString());



            }
            con.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from NowStudy where Username='" + st + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            rownum++;
            if (rownum < dt.Rows.Count)
            {

                txtlevel.Text = (dt.Rows[rownum]["Levels"].ToString());
                txtIns.Text = (dt.Rows[rownum]["Institute"].ToString());
                txtExam.Text = (dt.Rows[rownum]["ExamName"].ToString());
                txtachi.Text = (dt.Rows[rownum]["Achievements"].ToString());



            }
            con.Close(); ;
        }
    }
}
