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
    public partial class Login : Form
    {

        SqlConnection con = new SqlConnection("Data Source=Shehan-PC;Initial Catalog=Myplanner;Integrated Security=True");
        public static string passingtext;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            passingtext = txtname.Text;
            con.Open();
            SqlCommand  cmd=new SqlCommand("select * from Login where Username='"+txtname.Text+"' and Password='"+txtpassword.Text+"'",con);
            SqlDataReader adp;
            adp = cmd.ExecuteReader();
            int count = 0;
            while (adp.Read())
            {
                count += 1;
            }
            if (count == 1)
            {
               // MessageBox.Show("Successfully Login", " Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main m1 = new Main();
                m1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password incorret. ","Error", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            con.Close();
            txtname.Clear();
            txtpassword.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Register f3 = new Register();
            f3.Show();
            this.Hide();
        }
        
    }
}
