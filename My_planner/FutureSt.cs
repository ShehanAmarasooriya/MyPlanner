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
    public partial class FutureSt : Form
    {
        SqlConnection con = new SqlConnection("Data Source=Shehan-PC;Initial Catalog=Myplanner;Integrated Security=True");
        string st = Login.passingtext;
        public FutureSt()
        {
            InitializeComponent();
        }

        private void FutureSt_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into FutureSt(Username,Country,Ins,Exam,Durartion,Cost,Start) values('" + st + "','" + txtCountry.Text + "','" + txtIns.Text + "','" + txtExam.Text + "','" +txtduration.Text + "','" + txtcost.Text + "','" + dateTimePicker1.Text + "')", con);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
