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
    public partial class DoneStudies : Form
    {
        SqlConnection con = new SqlConnection("Data Source=Shehan-PC;Initial Catalog=Myplanner;Integrated Security=True");
        string st = Login.passingtext;
        public DoneStudies()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into NowStudy(UserName,Levels,Institute,ExamName,Achievements) values('" + st + "','" + comboBox1.Text+ "','" + txtinstitue.Text + "','" + txtExamName.Text + "','" +txtAchievements.Text + "')", con);
            SqlDataReader adp;

            try
            {
                adp = cmd.ExecuteReader();
                
                MessageBox.Show("Insert Successfully");
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
