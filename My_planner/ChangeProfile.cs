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
    public partial class ChangeProfile : Form
    {
        SqlConnection con = new SqlConnection("Data Source=Shehan-PC;Initial Catalog=Myplanner;Integrated Security=True");
        String imgLocation = " ";
        string st = Login.passingtext;
        public ChangeProfile()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeProfile_Load(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand cmd = new SqlCommand("select UserName,Password,Email,ContactNumber,Address,Image from Login where Username='" + st + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                String un = (dr["UserName"].ToString());
                String a = (dr["Password"].ToString());
                String c = (dr["Email"].ToString());
                String f = (dr["ContactNumber"].ToString());
                String h = (dr["Address"].ToString());

                txtUsername.Text = un;
                txtPassword.Text = a;
                txtEmail.Text = c;
                txtphone.Text = f;
                txtaddress.Text = h;
                
                //image load
                byte[] images = ((byte[])dr[5]);
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

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] images = null;
                FileStream streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(streem);
                images = brs.ReadBytes((int)streem.Length);

                con.Open();
                SqlCommand cmd = new SqlCommand("Update Login Set UserName='" + txtUsername.Text + "',Password='" + txtPassword.Text + "',Email='" + txtEmail.Text + "',ContactNumber='" + txtphone.Text + "',Address='" + txtaddress.Text + "',Image=@images where UserName='"+st+"'", con);
                cmd.Parameters.Add(new SqlParameter("@images", images));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Update Successfully");
            }
            catch
            {
                MessageBox.Show("Can't Open Connection");
            }
        }
    }
}
