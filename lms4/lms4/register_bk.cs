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
using System.Configuration;

namespace lms4
{
    public partial class register_bk : Form
    {
        string ConnectionString = "Data Source=DESKTOP-2FG81GO;Initial Catalog=library;User ID=sa;Password=sap";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sdr;
        DataTable dt;
        //SqlDataReader dr;
        public register_bk()
        {
            InitializeComponent();
        }
        //enable button controls
     public   void bookform_Enable() {
            buttonEcllipse1.Enabled = true;
            buttonEcllipse3.Enabled = true;
            buttonEcllipse4.Enabled = true;
        }

     public   void bookform_Disable()
        {
            buttonEcllipse1.Enabled = false;
            buttonEcllipse3.Enabled = false;
            buttonEcllipse4.Enabled = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbcat.Items.Clear();
            var val = cmbtyp.SelectedItem.ToString();
           string val2;
           val2 = (string)val;
            if (val2=="1") 
            {
                cmbcat.Items.Add("Art and Music");
            }
            else if (val2 == "2") 
            {
                cmbcat.Items.Add("Kids");
            }

            else if (val2 == "3")
            {
                cmbcat.Items.Add("Business");
            }
            else if (val2 == "4")
            {
                cmbcat.Items.Add("Computer and Tech");
            }
            else if (val2 == "5")
            {
                cmbcat.Items.Add("Cooking");
            }

            else if (val2 == "6")
            {
                cmbcat.Items.Add("Comics");
            }
            else if (val2 == "7")
            {
                cmbcat.Items.Add("Biographies");
            }
            else if (val2 == "8")
            {
                cmbcat.Items.Add("Hobbies and Crafts");
            }
            else if (val2 == "9")
            {
                cmbcat.Items.Add("Sports");
            }
            else
            {
                cmbcat.Items.Add("Sci-Fi and Fantancy");
            }

            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonEcllipse1_Click(object sender, EventArgs e)
        {
            clear();

        }

        private void buttonEcllipse2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEcllipse3_Click(object sender, EventArgs e)
        {
            //try
           // {
                //connection string
                string mainconn = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
                con = new SqlConnection(mainconn);
                
                //query string
                string cmd_query = "INSERT INTO book_tbl (Type_ID,category,title,ISBN,publisher_ID,A_ID,first_name,last_name,publication) values (@cmbtyp,@cmbcat,@title,@isbn,@cmbpub,@cmbauthor,@fname,@lname,@pub)";
                cmd = new SqlCommand(cmd_query,con);
                //parameters
                cmd.Parameters.AddWithValue("@cmbtyp", cmbtyp.Text);
                cmd.Parameters.AddWithValue("@cmbcat", cmbcat.Text);
                cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@isbn", txtISBN.Text);
                cmd.Parameters.AddWithValue("@cmbpub", cmbpub.Text);
                cmd.Parameters.AddWithValue("@cmbauthor", cmbauthor.Text);
                cmd.Parameters.AddWithValue("@fname", txtfname.Text);
                cmd.Parameters.AddWithValue("@lname", txtlname.Text);
                cmd.Parameters.AddWithValue("@pub", txtpub.Text);
               
                cmd.CommandType = CommandType.Text;

                //open connection
                con.Open();
                cmd.ExecuteNonQuery();
                //close  connection
                MessageBox.Show("record inserted successfully");
               
                //reset controls
                //clear();

            //}
            //catch (Exception ex)
            //{
             //   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            

        }

        private void register_bk_Load(object sender, EventArgs e)
        {
            pp();
            AA();
        }
        public void pp() {

            try
            {
                //string mainconn = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
               // con = new SqlConnection(mainconn);
                con = new SqlConnection(ConnectionString);
                string query = "select PUB_ID from [dbo].[publisher_tbl]";
                cmd = new SqlCommand(query, con);
                con.Open();
                sdr = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sdr.Fill(dt);
                cmbpub.DisplayMember = "PUB_ID";
                cmbpub.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AA() {
            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
                con = new SqlConnection(mainconn);
                string query = "select A_ID from [dbo].[author_tbl]";
                cmd = new SqlCommand(query, con);
                con.Open();
                sdr = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sdr.Fill(dt);
                cmbauthor.DisplayMember = "A_ID";
                //.DisplayMember = "A_ID";
                cmbauthor.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
        public void clear()
        {
            //reset controls
            cmbtyp.Text = "";
            cmbcat.Text = "";
            txtTitle.Text = "";
            txtISBN.Text = "";
            cmbpub.Text = "";
            txtpub.Text = "";
            cmbauthor.Text = "";
            txtfname.Text = "";
            txtlname.Text = "";
        
        }
        private void txtlname_TextChanged(object sender, EventArgs e)
        {

        }
        /*
        private void txtpub_TextChanged(object sender, EventArgs e)
        {
            string pubid = Convert.ToString(cmbpub.Text);
                
            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
                con = new SqlConnection(mainconn);
                string query = "select Publication from [dbo].[publisher_tbl] where PUB_ID='"+pubid+"'";
                cmd = new SqlCommand(query, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                { 
                  
                
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private void cmbpub_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
                con = new SqlConnection(mainconn);

                int cmb = Convert.ToInt32(cmbpub.Text);
                string query = "select * from [dbo].[publisher_tbl] where PUB_ID="+ cmb +"";
                cmd = new SqlCommand(query, con);
                con.Open();
                sdr = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sdr.Fill(dt);
                foreach (DataRow rw in dt.Rows)
                {
                    txtpub.Text = rw["Publication"].ToString();
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbauthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
                con = new SqlConnection(mainconn);

                int cmb = Convert.ToInt32(cmbauthor.Text);
                string query = "select * from [dbo].[author_tbl] where A_ID=" + cmb + "";
                cmd = new SqlCommand(query, con);
                con.Open();
                sdr = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sdr.Fill(dt);
                foreach (DataRow rw in dt.Rows)
                {
                    txtfname.Text = rw["First_Name"].ToString();
                    txtlname.Text = rw["Last_Name"].ToString();
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtpub_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEcllipse4_Click(object sender, EventArgs e)
        {
            //try { 

                string mainconn = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
                con = new SqlConnection(mainconn);

               //update query
                string cmd_query = "UPDATE book_tbl SET Type_ID=@cmbtyp,category=@cmbcat,title=@title,publisher_ID=@cmbpub,A_ID=@cmbauthor,first_name=@fname,last_name=@lname,publication=@pub WHERE ISBN=@isbn";
                cmd = new SqlCommand(cmd_query, con);
                //parameters
                cmd.Parameters.AddWithValue("@cmbtyp", cmbtyp.Text);
                cmd.Parameters.AddWithValue("@cmbcat", cmbcat.Text);
                cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@isbn", txtISBN.Text);
                cmd.Parameters.AddWithValue("@cmbpub", cmbpub.Text);
                cmd.Parameters.AddWithValue("@cmbauthor", cmbauthor.Text);
                cmd.Parameters.AddWithValue("@fname", txtfname.Text);
                cmd.Parameters.AddWithValue("@lname", txtlname.Text);
                cmd.Parameters.AddWithValue("@pub", txtpub.Text);

                cmd.CommandType = CommandType.Text;
                //int cmb = Convert.ToInt32(cmbauthor.Text);

                MessageBox.Show("record updated successfully");
                //reset controls
                clear();	
            
            
           // }
            //catch (Exception ex)
           // {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
                con = new SqlConnection(mainconn);

                //int cmb = Convert.ToInt32(cmbauthor.Text);
                string query = "select * from [dbo].[book_tbl] where ISBN=" + txtISBN.Text + "";
                cmd = new SqlCommand(query, con);
                con.Open();
                sdr = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sdr.Fill(dt);
                foreach (DataRow rw in dt.Rows)
                {
                    cmbtyp.Text=rw["Type_ID"].ToString();
                    cmbcat.Text = rw["category"].ToString();
                    txtTitle.Text = rw["title"].ToString();
                    cmbpub.Text = rw["publisher_ID"].ToString();
                    cmbauthor.Text = rw["A_ID"].ToString();
                    txtfname.Text = rw["First_Name"].ToString();
                    txtlname.Text = rw["Last_Name"].ToString();
                    txtpub.Text = rw["publication"].ToString();
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbcat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     /*   private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.publisher_tblTableAdapter.FillBy(this.libraryDataSet.publisher_tbl);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }*/


    }

    
}
