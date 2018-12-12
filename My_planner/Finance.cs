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
    public partial class Finance : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=Shehan-PC;Initial Catalog=Myplanner;Integrated Security=True");
        string st = Login.passingtext;
        int rownum = 0;
        public Finance()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewFinance NW = new NewFinance();
            NW.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Finance_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from FutureFinance where Username='" + st + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                lblname.Text = (dr["GoalName"].ToString());
                txtCOst.Text = (dr["Cost"].ToString());
                richTextBox1.Text = (dr["Conti"].ToString());
                lblstatrt.Text = (dr["Start"].ToString());
                txthand.Text = (dr["MoneyHand"].ToString());

            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string st = Login.passingtext;
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from FutureFinance where Username='" + st + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            rownum++;
            if (rownum < dt.Rows.Count)
            {

                lblname.Text = (dt.Rows[rownum]["GoalName"].ToString());
                txtCOst.Text = (dt.Rows[rownum]["Cost"].ToString());
                richTextBox1.Text = (dt.Rows[rownum]["Conti"].ToString());
                txthand.Text = (dt.Rows[rownum]["MoneyHand"].ToString());
                lblstatrt.Text = (dt.Rows[rownum]["Start"].ToString());



            }
            con.Close();


        }

        private void txthand_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnpre_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string st = Login.passingtext;
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from FutureFinance where Username='" + st + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            rownum--;
            if (rownum < 1)
            {
                lblname.Text = (dt.Rows[rownum]["GoalName"].ToString());
                txtCOst.Text = (dt.Rows[rownum]["Cost"].ToString());
                richTextBox1.Text = (dt.Rows[rownum]["Conti"].ToString());
                txthand.Text = (dt.Rows[rownum]["MoneyHand"].ToString());
                lblstatrt.Text = (dt.Rows[rownum]["Start"].ToString());


            }
            con.Close();
        }
    }
}
