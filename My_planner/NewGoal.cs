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
    public partial class NewGoal : Form
    {
        SqlConnection con = new SqlConnection("Data Source=Shehan-PC;Initial Catalog=Myplanner;Integrated Security=True");
        string st = Login.passingtext;
        public NewGoal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into FuturePer(Username,GoalName,GoalDescription,PossibleOb,Continpl,SkillR,PeopleR,ActionP,StartDate,EndDate,Reward) values('" + st + "','" + txtgoal.Text + "','" + richGoal.Text + "','" + richPossible.Text + "','" + richContingency.Text + "','" + richSkills.Text + "','" + richGroup.Text + "','" + richAction.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + richreward.Text + "')", con);
            SqlDataReader adp;

            try
            {
                adp = cmd.ExecuteReader();
                
                MessageBox.Show("Insert data Successfully!");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();

        }
    }
}
