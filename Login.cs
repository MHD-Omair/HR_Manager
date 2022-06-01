using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HR_Manager_AD0667
{
    public partial class frmLogin : Form
    {
        public TextBox txtUsername;

        public frmLogin()
        {
            InitializeComponent();
            txtUsername = txtUserName;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
         //   if (txtUserName.Text == "admin" && txtPassword.Text == "Admin")
         //   {
                pnlToNavi.BringToFront();

                frmNavigation frmNavigation = new frmNavigation() 
                { TopLevel = false, TopMost = true };

                frmNavigation.FormBorderStyle = FormBorderStyle.None;
                pnlToNavi.Controls.Add(frmNavigation);
                frmNavigation.Show();
           
            frmNavigation.instance.lblPUN.Text = "Welcome " + txtUsername.Text;
         //   }
         //   else
         //       MessageBox.Show("The Username or Password you entered is incorrect," 
         //           +" try agin");
         //       txtPassword.Clear();
         //       txtUserName.Clear();
         //       txtUserName.Focus();
        }
        private void lblUNBar_Click_1(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtUserName.Focus();
        }
        private void lblPWBar_Click_1(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }
    }
}
