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
    public partial class NewDoneFinance : Form
    {
        SqlConnection con = new SqlConnection("Data Source=Shehan-PC;Initial Catalog=Myplanner;Integrated Security=True");
        string st = Login.passingtext;
        public NewDoneFinance()
        {
           
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NewDoneFinance_Load(object sender, EventArgs e)
        {

        }

        private void btnsumbit_Click(object sender, EventArgs e)
        {
             con.Open();
            SqlCommand cmd = new SqlCommand("Insert into NowFinaces(Username,FinalGoal,TotalCost,Description,StartDate,EndDate) values('" + st + "','" + txtgoal.Text + "','" + txtcost.Text + "','"+richTextBox1.Text+"','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "')", con);
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
