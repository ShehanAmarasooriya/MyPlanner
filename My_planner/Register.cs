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
using System.IO;

namespace My_planner
{
    public partial class Register : Form
    {
        SqlConnection con = new SqlConnection("Data Source=Shehan-PC;Initial Catalog=Myplanner;Integrated Security=True");
        String imgLocation = " ";
        public Register()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
            Login f1 = new Login();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            byte[] images = null;
            FileStream streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(streem);
            images = brs.ReadBytes((int)streem.Length);

            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Login(Username,Password,FirstName,LastName,Email,ContactNumber,Dob,Address,Image) values('"+txtusername.Text+"','"+txtpassword.Text+"','"+txtfname.Text+"','"+txtlname.Text+"','"+txtemail.Text+"','"+txtcontact.Text+"','"+dateTimePicker1.Text+"','"+txtaddress.Text+"',@images)", con);
            cmd.Parameters.Add(new SqlParameter("@images", images));

            SqlDataReader adp;

            try
            {
                adp = cmd.ExecuteReader();
                this.Close();
                //MessageBox.Show("Create Account Successfully");
               
                Login f1 = new Login();
                f1.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            con.Close();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;

            }
        }
    }
}
