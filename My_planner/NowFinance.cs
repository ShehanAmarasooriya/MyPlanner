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
    public partial class NowFinance : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=Shehan-PC;Initial Catalog=Myplanner;Integrated Security=True");
        int rownum = 0;
        public NowFinance()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewDoneFinance NDF = new NewDoneFinance();
            NDF.Show();
        }

        private void NowFinance_Load(object sender, EventArgs e)
        {
            string st = Login.passingtext;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from NowFinaces where Username='" + st + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                richTextBox1.Text = (dr["Description"].ToString());
                lblname.Text = (dr["FinalGoal"].ToString());
                txtcost.Text = (dr["TotalCost"].ToString());
                lblstart.Text = (dr["StartDate"].ToString());
                lblend.Text = (dr["EndDate"].ToString());
                
            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string st = Login.passingtext;
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from NowFinaces where Username='" + st + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            rownum++;
            if (rownum < dt.Rows.Count)
            {

                richTextBox1.Text = (dt.Rows[rownum]["Description"].ToString());
                lblname.Text = (dt.Rows[rownum]["FinalGoal"].ToString());
                txtcost.Text = (dt.Rows[rownum]["TotalCost"].ToString());
                lblstart.Text = (dt.Rows[rownum]["StartDate"].ToString());
                lblend.Text = (dt.Rows[rownum]["EndDate"].ToString());
               


            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string st = Login.passingtext;
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from NowFinaces where Username='" + st + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            rownum--;
            if (rownum < 1)
            {
                richTextBox1.Text = (dt.Rows[rownum]["Description"].ToString());
                lblname.Text = (dt.Rows[rownum]["FinalGoal"].ToString());
                txtcost.Text = (dt.Rows[rownum]["TotalCost"].ToString());
                lblstart.Text = (dt.Rows[rownum]["StartDate"].ToString());
                lblend.Text = (dt.Rows[rownum]["EndDate"].ToString());



            }
            con.Close();
        }
    }
}
