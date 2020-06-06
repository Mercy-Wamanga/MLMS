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
//using System.Windows.Forms.

namespace lms4
{
    public partial class module__rights : Form
    {
        public module__rights()
        {
            InitializeComponent();
            combo();
        }
        string ConnectionString = "Data Source=DESKTOP-2FG81GO;Initial Catalog=library;User ID=sa;Password=sap";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader sdr;

        void combo()
        {
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

        private void buttonEcllipse2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void module__rights_Load(object sender, EventArgs e)
        {

        }
        register_bk bk;
        void bookformEnable() 
        {
           
        }
        void bookformDisable() 
        { 
        
        }

        private void buttonEcllipse4_Click(object sender, EventArgs e)
        {
            register_bk bk = new register_bk();
            register_member rm = new register_member();
            return_bk rbk = new return_bk();
            borrowbk bbk = new borrowbk();
            con = new SqlConnection(ConnectionString);
            string query = "select * from [dbo].[user_tbl] ";
            cmd = new SqlCommand(query, con);


            //create variables for 
           
            sdr = cmd.ExecuteReader();
            con.Open();
            while (sdr.Read())
            {
                string uname = sdr["username"].ToString();
                cmbUser.Items.Add(uname);

            }

           
        }
       


    } 
 
}
