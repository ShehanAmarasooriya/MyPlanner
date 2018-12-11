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
namespace My_planner
{
    public partial class SeeGoal : Form
    {
        SqlConnection con = new SqlConnection("Data Source=Shehan-PC;Initial Catalog=Myplanner;Integrated Security=True");
        string st = Login.passingtext;
        public SeeGoal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SeeGoal_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from FuturePer where Username='" + st + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                lblgoal.Text = (dr["GoalName"].ToString());
                richGoal.Text = (dr["GoalDescription"].ToString());
                richPossible.Text = (dr["PossibleOb"].ToString());
                richContin.Text = (dr["ContinPl"].ToString());
                richSkills.Text = (dr["SkillR"].ToString());
                richGroup.Text = (dr["PeopleR"].ToString());
                richAction.Text = (dr["ActionP"].ToString());
                lblstatrt.Text = (dr["StartDate"].ToString());
                lblend.Text = (dr["EndDate"].ToString());
                richreward.Text = (dr["Reward"].ToString());
                con.Close();
            }
        }
    }
}

