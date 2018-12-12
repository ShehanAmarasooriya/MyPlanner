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
    public partial class Personal_Now : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=Shehan-PC;Initial Catalog=Myplanner;Integrated Security=True");
        string st = Login.passingtext;
        int rownum = 0;
        public Personal_Now()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersoanlNowAdd C = new PersoanlNowAdd();
            C.Show();
        }

        private void Personal_Now_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from PersonalNow where Username='" + st + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                String a = (dr["GoalName"].ToString());
                String b = (dr["Description"].ToString());
                String c = (dr["StartDate"].ToString());
                String d = (dr["EndDate"].ToString());


                lblgoal.Text = a;
                richTextBox1.Text = b;
                lblstart.Text = c;
                lblEnd.Text = d;
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string st = Login.passingtext;
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from PersonalNow where Username='" + st + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            rownum++;
            if (rownum < dt.Rows.Count)
            {

                lblgoal.Text = (dt.Rows[rownum]["GoalName"].ToString());
                richTextBox1.Text = (dt.Rows[rownum]["Description"].ToString());
                lblstart.Text = (dt.Rows[rownum]["StartDate"].ToString());
                lblEnd.Text = (dt.Rows[rownum]["EndDate"].ToString());

                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string st = Login.passingtext;
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from PersonalNow where Username='" + st + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            rownum--;
            if (rownum < 1)
            {

                lblgoal.Text = (dt.Rows[rownum]["GoalName"].ToString());
                richTextBox1.Text = (dt.Rows[rownum]["Description"].ToString());
                lblstart.Text = (dt.Rows[rownum]["StartDate"].ToString());
                lblEnd.Text = (dt.Rows[rownum]["EndDate"].ToString());



            }
            con.Close();
        }
    }
}
