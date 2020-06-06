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
    public partial class register_member : Form
    {
        public register_member()
        {
            InitializeComponent();
        }

        string ConnectionString = "Data Source=DESKTOP-2FG81GO;Initial Catalog=library;User ID=sa;Password=sap";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sdr;
        DataTable dt;

       public void memberForm_Enable() { 
           btnNew.Enabled=true;
           btnSave.Enabled = true;
           btnEdit.Enabled = true;
        }

     public   void memberForm_Disable()
        {
            btnNew.Enabled = false;
            btnSave.Enabled = false;
            btnEdit.Enabled = false;
        }

        public void clear()
        {
            //reset controls
            txtmemberid.Text = "";
            txtfirstname.Text = "";
            txtlastname.Text = "";
            txtusername.Text = "";
            txtemail.Text = "";
            txtpnumber.Text = "";
            txtaddress.Text = "";
            dtreg_date.Text = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtmemberid.Enabled = false;
            clear();
            txtfirstname.Focus();
            try{
            DateTime datetime = Convert.ToDateTime(dtreg_date.Text);
            string cmd_query = "INSERT INTO member_tbl values('" + txtfirstname.Text + "','" + txtlastname.Text + "','" + txtusername.Text + "','" + txtemail.Text + "','" + txtpnumber.Text + "','" + txtaddress.Text + "','" + datetime + "' )";
            con = new SqlConnection(ConnectionString);

            con.Open();
            //cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = cmd_query;//"INSERT INTO user_tbl values('" + txtuname.Text + "','" + txtfname.Text + "','" + txtlname.Text + ",'" + txtemail.Text + "','" + txtpnumber.Text + "','" + txtaddress.Text + "','" + txtpword.Text + "','" + cmbreg_date.Text + "' )"; ;
            cmd.ExecuteNonQuery();
            con.Close();

                 MessageBox.Show("record inserted successfully");
                  clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime datetime = Convert.ToDateTime(dtreg_date.Text);
                string cmd_query = "UPDATE member_tbl SET firstname='" + txtfirstname.Text + "',lastname='" + txtlastname.Text + "',username='" + txtusername.Text + "',email='" + txtemail.Text + "',phonenumber='" + txtpnumber.Text + "',address='" + txtaddress.Text + "',reg_date='" + datetime + "' ";
                con = new SqlConnection(ConnectionString);

                con.Open();
                //cmd = new SqlCommand();
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = cmd_query;//"INSERT INTO user_tbl values('" + txtuname.Text + "','" + txtfname.Text + "','" + txtlname.Text + ",'" + txtemail.Text + "','" + txtpnumber.Text + "','" + txtaddress.Text + "','" + txtpword.Text + "','" + cmbreg_date.Text + "' )"; ;
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("record updated successfully");
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtmemberid_TextChanged(object sender, EventArgs e)
        {
           // DateTime datetime = Convert.ToDateTime(dtreg_date.Text);
           // try
           // {
                string query = "select * from [dbo].[member_tbl] where member_ID=" + txtmemberid.Text + "";
                con = new SqlConnection(ConnectionString);
                cmd = new SqlCommand(query, con);
                con.Open();
                sdr = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sdr.Fill(dt);
                foreach (DataRow rw in dt.Rows)
                {

                    txtfirstname.Text = rw["firstname"].ToString();
                    txtlastname.Text = rw["lastname"].ToString();
                    txtusername.Text = rw["username"].ToString();
                    txtemail.Text = rw["email"].ToString();
                    txtpnumber.Text = rw["phonenumber"].ToString();
                    txtaddress.Text = rw["address"].ToString();
                    dtreg_date.Text = rw["reg_date"].ToString();
                    // txtlname.Text = rw["Last_Name"].ToString();
                    //txtpub.Text = rw["publication"].ToString();
                }
                con.Close();


           // }
           // catch (Exception ex)
           // {
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           // }
           

        }

        private void register_member_Load(object sender, EventArgs e)
        {
           // txtmemberid.Enabled = false;
/*
            if (comboselect.SelectedItem == "Insert")
            {
                txtmemberid.Enabled = false;
                txtfirstname.Enabled = true;
                txtlastname.Enabled = true;
                txtusername.Enabled = true;
                txtemail.Enabled = true;
                txtpnumber.Enabled = true;
                txtaddress.Enabled = true;
                dtreg_date.Enabled = true;
            }
            else if (comboselect.SelectedItem == "Edit")
            {
                txtmemberid.Enabled = true;
                txtfirstname.Enabled = true;
                txtlastname.Enabled = true;
                txtusername.Enabled = true;
                txtemail.Enabled = true;
                txtpnumber.Enabled = true;
                txtaddress.Enabled = true;
                dtreg_date.Enabled = true;
            }
            else
            {
               // MessageBox.Show("Please specify action!!!!!!!!!!!!");
            }*/
        }

        private void comboselect_SelectedIndexChanged(object sender, EventArgs e)
        {
          string val= comboselect.SelectedItem.ToString();
            if (val== "Insert")
            {
                txtmemberid.Enabled = false;
                txtfirstname.Enabled = true;
                txtlastname.Enabled = true;
                txtusername.Enabled = true;
                txtemail.Enabled = true;
                txtpnumber.Enabled = true;
                txtaddress.Enabled = true;
                dtreg_date.Enabled = true;
                txtfirstname.Focus();
            }
            else if (val== "Edit")
            {
                txtmemberid.Enabled = true;
                txtfirstname.Enabled = true;
                txtlastname.Enabled = true;
                txtusername.Enabled = true;
                txtemail.Enabled = true;
                txtpnumber.Enabled = true;
                txtaddress.Enabled = true;
                dtreg_date.Enabled = true;
                txtmemberid.Focus();
            }
            else
            {
                MessageBox.Show("Please specify action!!!!!!!!!!!!");
            }
            
        }
    }
}
