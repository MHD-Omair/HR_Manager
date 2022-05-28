using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;


namespace HR_Manager_AD0667
{
    public partial class frmAttendance : Form
    {
        // list to hold all the degree

        private int StudentCounter = 0;

        public frmAttendance()
        {
            InitializeComponent();
        }
        private void frmAttendance_Load(object sender, EventArgs e)
        {
            StudentCounter++;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "a->z")
            {
                // بنرجعلك يباشا
            }
            else
            {
            }
        }
    }
}
