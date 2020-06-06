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
    public partial class return_bk : Form
    {
        public return_bk()
        {
            InitializeComponent();
        }

        string ConnectionString = "Data Source=DESKTOP-2FG81GO;Initial Catalog=library;User ID=sa;Password=sap";
        SqlConnection con;
        SqlCommand cmd;
        //SqlDataAdapter sdr;
        //DataTable dt;
        public void clear() {
            txtbookID.Text = "";
            txtborrowID.Text = "";
            dt_return.Text = "";
        
        }

        public void Return_Enable() {

            btnNew.Enabled = true;
            buttonEcllipse5.Enabled = true;
        }

      public  void Return_Disable()
        {

            btnNew.Enabled = false;
            buttonEcllipse5.Enabled = false;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonEcllipse1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void buttonEcllipse3_Click(object sender, EventArgs e)
        {
            //saving data in database
            //DateTime datetime1 = Convert.ToDateTime(dt_issue.Text);
            DateTime datetime = Convert.ToDateTime(dt_return.Text);

            string cmd_query = "INSERT INTO return_tbl values(" + txtborrowID.Text + "," + txtbookID.Text + ",'" + datetime + "' )";
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

        private void buttonEcllipse2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void return_bk_Load(object sender, EventArgs e)
        {

        }
    }
}
