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
    public partial class PersoanlNowAdd : Form
    {
        SqlConnection con = new SqlConnection("Data Source=Shehan-PC;Initial Catalog=Myplanner;Integrated Security=True");
        string st = Login.passingtext;
        public PersoanlNowAdd()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into PersonalNow(Username,GoalName,Description,StartDate,EndDate) values('" +st + "','"+txtgoalName.Text+"','"+richTextBox1.Text+"','"+dateTimePicker1.Text+"','"+dateTimePicker2.Text+"')", con);
            SqlDataReader adp;

            try
            {
                adp = cmd.ExecuteReader();
                this.Close();
                MessageBox.Show("Insert data Successfully!");

                Main f1 = new Main();
                f1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }
    }
}
