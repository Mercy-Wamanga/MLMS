using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;


namespace lms4
{
    public partial class login : Form 
    {
        
        public login()
        {
            InitializeComponent();
            //this.FormBorderStyle=
            //
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader sdr;
        public static string loginuser = "";
        string ConnectionString = "Data Source=DESKTOP-2FG81GO;Initial Catalog=library;User ID=sa;Password=sap";

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {
            var content = (string)cmb_usertyp.SelectedItem;
           
           
           
        }
       
        private void cmb_usertyp_SelectedIndexChanged(object sender, EventArgs e)
        {

            var content = (string)cmb_usertyp.SelectedItem;
                //ComboBox content=(String)cmb_usertyp.SelectedItem;
            if (content == null)
            {
                txtusername.Enabled = false;
                txtpassword.Enabled = false;
                btnlogin.Enabled = false;
                btncancel.Enabled = false;

            }
            else
            {
                txtusername.Enabled = true;
                txtpassword.Enabled = true;
                btnlogin.Enabled = true;
                btncancel.Enabled = true;

            }

             if (content == "Admin")
            {
                txtusername.Text = cmb_usertyp.SelectedItem.ToString();
                txtusername.Enabled = false;
            }
             
            
            else {
                txtusername.Text = "";
                txtusername.Enabled = true;
                txtpassword.Enabled = true;
                btnlogin.Enabled = true;
                btncancel.Enabled = true;
            }
           
        }

        public void btnlogin_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-2FG81GO;Initial Catalog=library;User ID=sa;Password=sap";
            try
            {


                if (txtusername.Text == "" && txtpassword.Text == "")
                {
                    MessageBox.Show("Please Enter Both Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    SqlConnection con = new SqlConnection(ConnectionString);
               
                    string cmd_query = "SELECT * FROM user_tbl WHERE username=@UserName AND user_password=@UserPass";
                   // string status_query="SELECT * FROM user_tbl";
                    SqlCommand cmd = new SqlCommand(cmd_query, con);
                    string statusy = Convert.ToString(cmbstatus);
                   // SqlCommand cmd1 = new SqlCommand(status_query,con);
                    cmd.Parameters.AddWithValue("@UserName", txtusername.Text);
                    cmd.Parameters.AddWithValue("@UserPass", txtpassword.Text);
                    

                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                  
                    DataSet tbl = new DataSet();
                    sda.Fill(tbl);
                   
                    //string status=
                    int count = tbl.Tables[0].Rows.Count;
                    if (count == 1)
                    {
                        SqlDataReader rd = cmd.ExecuteReader();
                        //string status = rd["status"].ToString();
                       while (rd.Read())
                       {
                           if (cmbstatus.Text=="Activate")
                            {

                                MessageBox.Show("You have logged in successfully " + txtusername.Text);
                                string uname = txtusername.Text;

                                Workstation ws = new Workstation();
                                loginuser = txtusername.Text;
                                ws.Show();
                                this.Hide();
                           }
                           else 
                           {
                                MessageBox.Show("Please have the administrator activate your account before login");
                                this.Close();
                           }
                        }
                      
                    }
                    else
                    {
                        MessageBox.Show("Login Failed...Try again !", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       
                    }

                    con.Close();  

                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(ConnectionString);
                string query = "select * from [dbo].[user_tbl] where username='"+txtusername.Text+"'";
                cmd = new SqlCommand(query, con);

                con.Open();
                //sdr = new SqlDataReader();
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    string st = sdr["status"].ToString();
                    cmbstatus.Items.Add(st);
                    cmbstatus.SelectedIndex = 0;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
           
        }
  
    












    
    
}
