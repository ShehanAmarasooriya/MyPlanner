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
using System.IO;

namespace My_planner
{
    public partial class MyProfile : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=Shehan-PC;Initial Catalog=Myplanner;Integrated Security=True");
        public MyProfile()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeProfile Cp = new ChangeProfile();
            Cp.Show();
        }

        private void MyProfile_Load(object sender, EventArgs e)
        {
            string st = Login.passingtext;
            con.Open();
            SqlCommand cmd = new SqlCommand("select UserName,FirstName,LastName,Email,ContactNumber,Dob,Address,Image from Login where Username='" + st + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                String un = (dr["UserName"].ToString());
                String a = (dr["FirstName"].ToString());
                String b = (dr["LastName"].ToString());
                String c = (dr["Email"].ToString());
                String f = (dr["ContactNumber"].ToString());
                String g = (dr["Dob"].ToString());
                String h = (dr["Address"].ToString());

                lblname.Text = a;
                lblFullname.Text = a + " " + b;
                lblEmail.Text = c;
                lblContatctNumber.Text = f;
                lblAddress.Text = h;
                lblpetname.Text = un;
                lblBirthday.Text = g;
                //image load
                byte[] images = ((byte[])dr[7]);
                if (images == null)
                {
                    pictureBox1.Image = null;
                }
                else
                {
                    MemoryStream mstreem = new MemoryStream(images);
                    pictureBox1.Image = Image.FromStream(mstreem);
                }
            }
            
            con.Close();
        }
    }
}
