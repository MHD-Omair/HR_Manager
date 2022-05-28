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
    public partial class frmAddDegree : Form
    {
        public frmAddDegree()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEmolpyees frmAddEmolpyees = new frmAddEmolpyees();
            frmAddEmolpyees.receiveData(txtAddDegree.Text);

            this.Close();
        }
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
