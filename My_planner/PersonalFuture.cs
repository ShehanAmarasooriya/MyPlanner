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
    public partial class PersonalFuture : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=Shehan-PC;Initial Catalog=Myplanner;Integrated Security=True");
        string st = Login.passingtext;
        public PersonalFuture()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewGoal NW = new NewGoal();
            NW.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SeeGoal Sg = new SeeGoal();
            Sg.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PersonalFuture_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from FuturePer where Username='" + st + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                lblname.Text = (dr["GoalName"].ToString());
                richdis.Text = (dr["GoalDescription"].ToString());
                richaction.Text = (dr["ActionP"].ToString());
                lblstatr.Text = (dr["StartDate"].ToString());
                lblend.Text = (dr["EndDate"].ToString());
                con.Close();
            }
        }
    }
}
