using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;


namespace HR_Manager_AD0667
{
    public partial class frmAttendance : Form
    {
        // list to hold all the degree

        private int EmployeeCounter = 0;

        public frmAttendance()
        {
            InitializeComponent();
        }
        private void frmAttendance_Load(object sender, EventArgs e)
        {
            EmployeeCounter++;
          //  dgvAttendance.DataSource = EmployeeDAL.GetAllPatients();

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
       /* private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                Employee newEmployee = new Employee();
                newEmployee.EmployeeName = textBox3.Text;

                EmployeeDAL.CreateEmployee(newEmployee);

                dgvAttendance.DataSource = EmployeeDAL.GetAllEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/
    }
}
