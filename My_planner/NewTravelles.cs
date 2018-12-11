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
    public partial class NewTravelles : Form
    {
        SqlConnection con = new SqlConnection("Data Source=Shehan-PC;Initial Catalog=Myplanner;Integrated Security=True");
        String imgLocation = " ";
        string st = Login.passingtext;
        public NewTravelles()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {

            byte[] images = null;
            FileStream streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(streem);
            images = brs.ReadBytes((int)streem.Length);

            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into NowTravel(Username,Description,place,Image) values('" + st+ "','" + richTextBox1.Text + "','"+txtplace.Text+"',@images)", con);
            cmd.Parameters.Add(new SqlParameter("@images", images));

            SqlDataReader adp;

            try
            {
                adp = cmd.ExecuteReader();
                MessageBox.Show("Successfully Insert");
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
