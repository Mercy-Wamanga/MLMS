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
    public partial class Workstation : Form
    {
        public Workstation()
        {
            InitializeComponent();
        }

        private void buttonEcllipse8_Click(object sender, EventArgs e)
        {
            //link to usermanagement form
            usermanagement us = new usermanagement();
            us.Show();
        }

        private void btn_admin_no_bk_Click(object sender, EventArgs e)
        {
            //link to number of books remaining
            Number_of_Books nbk = new Number_of_Books();
            nbk.Show();
        }

        private void btn_link_reports_Click(object sender, EventArgs e)
        {
            //link to number of books remaining
            Reports rbk = new Reports();
            rbk.Show();

        }

        private void btn_module_rights_Click(object sender, EventArgs e)
        {
            //link to module rights 
            module__rights mr = new module__rights();
            mr.Show();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            //link to add book
            register_bk rbk = new register_bk();
            rbk.Show();
        }

        private void btn_addmember_Click(object sender, EventArgs e)
        {
            //link to add member
            register_member rm = new register_member();
            rm.Show();
        }

        private void btn_borrow_Click(object sender, EventArgs e)
        {
            //link to borrow book form
            borrowbk bk = new borrowbk();
            bk.Show();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            //link to return book form
            return_bk rbk = new return_bk();
            rbk.Show();
        }

        private void Workstation_Load(object sender, EventArgs e)
        {
           if(login.loginuser!=null)
           {
               lbl_username.Text = login.loginuser;
           }

          /* if (login.loginuser == "Admin") {
               admin.Show();
               lib.Hide();
           
           }*/

         /*  if ((lbl_username.Text == "Admin") && (wrkstation.SelectedTab == lib))
           {
               MessageBox.Show("Unable to load tab. Please login as librarian o access this page.");
               wrkstation.SelectedTab = admin;
           }*/


        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void wrkstation_Selected(object sender, TabControlEventArgs e)
        {
         /*   if (lbl_username.Text == "Admin")
            {
                admin.Focus();
                lib.Hide();
            }
          */
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabcontrol(object sender, EventArgs e)
        {

        }

        private void tabcontrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((lbl_username.Text == "Admin") && (wrkstation.SelectedTab == admin))
            {
               // MessageBox.Show("Unable to load tab. Please login as librarian o access this page.");
                wrkstation.SelectedTab =admin;
            }

            else if ((lbl_username.Text != "Admin") && (wrkstation.SelectedTab == admin))
            {
                MessageBox.Show("Unable to load tab. You have insufficient access privileges.");
                wrkstation.SelectedTab = lib;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            welcome wl = new welcome();
            wl.Show();
        }

      
    }
}
