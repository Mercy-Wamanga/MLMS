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
using System.Data.Common;

namespace lms4
{
    public partial class usermanagement : Form
    {
        string ConnectionString = "Data Source=DESKTOP-2FG81GO;Initial Catalog=library;User ID=sa;Password=sap";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader sdr;
        //DataTable dt;
        public usermanagement()
        {
            InitializeComponent();
            combo();
        }

        void combo() {
            try
            {
            con = new SqlConnection(ConnectionString);
            string query = "select * from [dbo].[user_tbl] ";
            cmd = new SqlCommand(query, con);
          
                con.Open();
                //sdr = new SqlDataReader();
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    string uname = sdr["username"].ToString();
                        cmbUser.Items.Add(uname);         
                }
            }

            catch (Exception ex)
           {
               MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }

        }

        private void buttonEcllipse4_Click(object sender, EventArgs e)
        {
            try
            {
                //DateTime datetime = Convert.ToDateTime(dtreg_date.Text);
                string cmd_query = "UPDATE user_tbl SET status='" + cmbstatus.Text  + "' where username='"+cmbUser.Text+"'";
                con = new SqlConnection(ConnectionString);

                con.Open();
                //cmd = new SqlCommand();
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = cmd_query;//"INSERT INTO user_tbl values('" + txtuname.Text + "','" + txtfname.Text + "','" + txtlname.Text + ",'" + txtemail.Text + "','" + txtpnumber.Text + "','" + txtaddress.Text + "','" + txtpword.Text + "','" + cmbreg_date.Text + "' )"; ;
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("status updated successfully");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }   
 
        

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void usermanagement_Load(object sender, EventArgs e)
        {

        }

        private void buttonEcllipse2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
