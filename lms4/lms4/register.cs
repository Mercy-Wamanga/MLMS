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

namespace lms4
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        string ConnectionString = "Data Source=DESKTOP-2FG81GO;Initial Catalog=library;User ID=sa;Password=sap";
        SqlConnection con;
        SqlCommand cmd;
        //SqlDataAdapter sda;
        //DataSet tbl;

        private void register_Load(object sender, EventArgs e)
        {
            cmbcombo.SelectedIndex = 0;
        }

        private void buttonEcllipse2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearTextBoxes(Control c)
        {
            foreach (var tb in c.Controls.OfType<TextBox>())
            {
                tb.Text = null;
            }
            
        }

        private void buttonEcllipse1_Click(object sender, EventArgs e)
        {
            DateTime datetime = Convert.ToDateTime(cmbreg_date.Text);
            
            string cmd_query = "INSERT INTO user_tbl values('" + txtuname.Text + "','" + txtfname.Text + "','" + txtlname.Text + "','" + txtemail.Text + "','" + txtpnumber.Text + "','" + txtaddress.Text + "','" + txtpword.Text + "','" + datetime + "','"+ cmbcombo.Text+"' )";
            con = new SqlConnection(ConnectionString);
            if (txtpword.Text != txtcpword.Text)
            {
                MessageBox.Show("The passwords do not match", "please try again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcpword.Focus();

            }
            else
            {
                con.Open();
                //cmd = new SqlCommand();
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = cmd_query;//"INSERT INTO user_tbl values('" + txtuname.Text + "','" + txtfname.Text + "','" + txtlname.Text + ",'" + txtemail.Text + "','" + txtpnumber.Text + "','" + txtaddress.Text + "','" + txtpword.Text + "','" + cmbreg_date.Text + "' )"; ;
                cmd.ExecuteNonQuery();
                con.Close();

                //string msg = 
                MessageBox.Show("record inserted successfully");
                //reset controls
                txtuname.Text = "";
                txtfname.Text = "";
                txtlname.Text = "";
                txtemail.Text = "";
                txtpnumber.Text = "";
                txtaddress.Text = "";
                txtpword.Text = "";
                txtcpword.Text = "";
                cmbreg_date.Text = "";

                this.Hide();
                login lg = new login();
                lg.Show();


            }
        }

        private void cmbreg_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmbcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
