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
    public partial class NewFinance : Form
    {
        SqlConnection con = new SqlConnection("Data Source=Shehan-PC;Initial Catalog=Myplanner;Integrated Security=True");
        string st = Login.passingtext;
        public NewFinance()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into FutureFinance(UserName,GoalName,Cost,Conti,Start,MoneyHand) values('" + st + "','" + txtgoalName.Text + "','" + txtCost.Text + "','" + richTextBox1.Text + "','" + dateTimePicker1.Text + "','"+txtHand.Text+"')", con);
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
