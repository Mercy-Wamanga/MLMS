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
    public partial class borrowbk : Form
    {
        public borrowbk()
        {
            InitializeComponent();
        }

        string ConnectionString = "Data Source=DESKTOP-2FG81GO;Initial Catalog=library;User ID=sa;Password=sap";
        SqlConnection con;
        SqlCommand cmd;
       // SqlDataAdapter sdr;
       // DataTable dt;

       public void Borrowform_Enable() {
            btnNew.Enabled = true;
            btnSave.Enabled = true;
        }
      public  void Borrowform_Disable(){
            btnNew.Enabled = false;
            btnSave.Enabled = false;
        }

        public void clear()
        {
            txtmember_ID.Text = "";
            txtbookID.Text = "";
            dt_issue.Text = "";
            dt_return.Text = "";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            //close form

            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //saving data in database
            DateTime datetime1 = Convert.ToDateTime(dt_issue.Text);
            DateTime datetime2 = Convert.ToDateTime(dt_return.Text);

            string cmd_query = "INSERT INTO borrow_tbl values(" + txtmember_ID.Text + "," + txtbookID.Text + ",'" + datetime2 + "','" + datetime2 + "' )";
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void borrowbk_Load(object sender, EventArgs e)
        {

        }
    }
}
