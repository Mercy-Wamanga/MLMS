using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lms4
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void buttonEcllipse3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_welcome_login_Click(object sender, EventArgs e)
        {
         //link to login form
            login lg = new login();
            lg.Show();
        }

        private void btn_welcome_register_Click(object sender, EventArgs e)
        {
            //link to register form
            register rg = new register();
            rg.Show();
        }

        private void btn_welcome_addmember_Click(object sender, EventArgs e)
        {
            DialogResult mes = MessageBox.Show("Please first log into System!", "security alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (mes == DialogResult.OK) 
            {
                login lg = new login();
                lg.Show();
            }
           
            //link to register member
            //register_member rm = new register_member();
            //rm.Show();
        }

        private void btn_welcome_addbk_Click(object sender, EventArgs e)
        {

            DialogResult mes = MessageBox.Show("Please first log into System!", "security alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (mes == DialogResult.OK)
            {
                login lg = new login();
                lg.Show();
            }
           
            //link to register book
            //register_bk bk = new register_bk();
            //bk.Show();
        }

        private void btn_weelcome_borrow_Click(object sender, EventArgs e)
        {


            DialogResult mes = MessageBox.Show("Please first log into System!", "security alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (mes == DialogResult.OK)
            {
                login lg = new login();
                lg.Show();
            }
           
            //link to borrow book form
            //borrowbk bbk = new borrowbk();
            //bbk.Show();
        }

        private void buttonEcllipse1_Click(object sender, EventArgs e)
        {
            DialogResult mes = MessageBox.Show("Please first log into System!", "security alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (mes == DialogResult.OK)
            {
                login lg = new login();
                lg.Show();
            }
           
            //link to return book form
            //return_bk rb = new return_bk();
            //rb.Show();
        }
    }
}
