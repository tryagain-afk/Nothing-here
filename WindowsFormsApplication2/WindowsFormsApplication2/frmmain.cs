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
    public partial class frmmain : Form
    {
        string connectionstring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\user\documents\visual studio 2013\Projects\WindowsFormsApplication2\WindowsFormsApplication2\Database1.mdf;Integrated Security=True";
        public frmmain(string str_Value)
        {
            InitializeComponent();
            label1.Text = str_Value;


        }

        public frmmain()
        {
            // TODO: Complete member initialization
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.contacts' table. You can move, or remove it, as needed.
            this.contactsTableAdapter.Fill(this.database1DataSet.contacts);

        }

        private void ll1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmlogin objfrmlogin = new frmlogin();
            this.Hide();
            objfrmlogin.Show();
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select*from contacts", sqlcon);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                textBox2.DataBindings.Add(new Binding("Text", contactsBindingSource, "firstname", true));
                textBox3.DataBindings.Add(new Binding("Text", contactsBindingSource, "lastname", true));
                textBox4.DataBindings.Add(new Binding("Text", contactsBindingSource, "email", true));
                textBox5.DataBindings.Add(new Binding("Text", contactsBindingSource, "phonenumber", true));
            }
        }
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select*from contacts", sqlcon);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                dtbl = dataGridView1.DataSource as DataTable;
                DataRow row = dtbl.NewRow();
                row[1] = textBox2.Text.ToString();
                row[2] = textBox3.Text.ToString();
                row[3] = textBox4.Text.ToString();
                row[4] = textBox5.Text.ToString();
                dtbl.Rows.Add(row);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            string sqlquery = "select * from [dbo].[contacts] where lastname like'" + textBox6.Text + "%'";
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand(sqlquery, sqlcon);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcom);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlcon.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            string sqlquery = "select * from [dbo].[contacts] where addressid like'" + textBox1.Text + "%'";
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand(sqlquery, sqlcon);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcom);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlcon.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox2.Text = row.Cells["firstname"].Value.ToString();
                textBox3.Text = row.Cells["lastname"].Value.ToString();
                textBox4.Text = row.Cells["email"].Value.ToString();
                textBox5.Text = row.Cells["phonenumber"].Value.ToString();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowindex);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                SqlDataAdapter adap = new SqlDataAdapter("select addressid,firstname as 'first name',lastname as 'last name',email as 'email',phonenumber as 'phone number' from contacts", con);
                DataSet ds = new System.Data.DataSet();
                adap.Fill(ds, "contacts");
                dataGridView1.DataSource = ds.Tables[0];
                SqlCommandBuilder cmdbl = new SqlCommandBuilder(adap);
                adap.Update(ds,"contacts");
                MessageBox.Show("Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }
    }
}
