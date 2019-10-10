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

namespace WindowsFormsApplication2
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }
        string connetionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\user\documents\visual studio 2013\Projects\WindowsFormsApplication2\WindowsFormsApplication2\Database1.mdf;Integrated Security=True";
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            openFileDialog1.Filter = "image files(*.jpg;*.jpeg;*.gif;*.bmp;)|*.jpg;*.jpeg;*.gif;*.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtnimage.Text = open.FileName;
                pbpic.Image = new Bitmap(open.FileName);


            }
        }
        byte[] convertimagetobinary(Image ing)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                ing.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtnusername.Text == "" || txtnpassword.Text == "" || txtnimage.Text == "")
                MessageBox.Show("please fill in all the textbox");
            else
            using (SqlConnection sqlcon = new SqlConnection(connetionString)) 
            {               
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("userlogin", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@username", txtnusername.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@password", txtnpassword.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@image", convertimagetobinary(pbpic.Image));
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("registration is successfull");
                clear();
            }
            
        }
        void clear()
        {
            txtnimage.Text = txtnpassword.Text = txtnusername.Text="";
            pbpic.Image = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\user\documents\visual studio 2013\Projects\WindowsFormsApplication2\WindowsFormsApplication2\Database1.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open!");
            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\user\documents\visual studio 2013\Projects\WindowsFormsApplication2\WindowsFormsApplication2\Database1.mdf;Integrated Security=True");
            String query = "select * from login where username='" + txtusername.Text.Trim() + "'and password='" + txtpassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, cnn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            frmmain form2 = new frmmain(txtusername.Text);
            form2.ShowDialog();
            if (dtbl.Rows.Count == 1)
            {
                frmmain objfrmmain = new frmmain();
                this.Hide();
                objfrmmain.Show();

            }
            else
            {
                MessageBox.Show("please check your username or password");
            }
        }
    }
}
