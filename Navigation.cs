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
    public partial class frmNavigation : Form
    {
        public static frmNavigation instance;
        // this is for link labale PUserName to txtUser Name
        public Label lblPUN;
        public frmNavigation()
        {
            InitializeComponent();
            instance = this;
            lblPUN = lblPUserName;
        }
        private void btnDepartmentofHR_Click(object sender, EventArgs e)
        {
            pnlDisplayForms.Controls.Clear();
            frmAddEmolpyees frmAddEmolpyees = new frmAddEmolpyees()
            { TopLevel = false, TopMost = true };

            pnlDisplayForms.Controls.Add(frmAddEmolpyees);
            frmAddEmolpyees.FormBorderStyle = FormBorderStyle.None;
            frmAddEmolpyees.Show();
        }
        private void btnAttendance_Click(object sender, EventArgs e)
        {
            pnlDisplayForms.Controls.Clear();
            frmAttendance frmAttendance = new frmAttendance()
            { TopLevel = false, TopMost = true };

            pnlDisplayForms.Controls.Add(frmAttendance);
            frmAttendance.FormBorderStyle = FormBorderStyle.None;
            frmAttendance.Show();
        }
    }
}
