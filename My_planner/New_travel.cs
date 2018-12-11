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
    public partial class New_travel : Form
    {
        SqlConnection con = new SqlConnection("Data Source=Shehan-PC;Initial Catalog=Myplanner;Integrated Security=True");
        string st = Login.passingtext;
        public New_travel()
        {
            InitializeComponent();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnsercah_Click(object sender, EventArgs e)
        {
            String place = txtplace.Text;
            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("https://www.google.lk/maps/place/" + place);
                webBrowser1.Navigate(queryaddress.ToString());
            }
            catch
            {
                MessageBox.Show("Please insert a place to visit");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into FutureTr(Username,Place,Departure,bring,buget) values('" + st + "','" + txtplace.Text + "','" + dateTimePicker1.Text + "','" +richTextBox1.Text + "','" + richTextBox2.Text + "')", con);
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
