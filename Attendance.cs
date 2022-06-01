using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace HR_Manager_AD0667
{
    public partial class frmAttendance : Form
    {
        private static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
        "Data Source=C:\\Users\\mhdom\\source\\repos\\MHD-Omair\\HR_Manager\\DataBase";

        OleDbConnection connection;
        private int EmployeeCounter = 0;

        public frmAttendance()
        {
            connection = new OleDbConnection(connectionString);
            InitializeComponent();
        }
        private void frmAttendance_Load(object sender, EventArgs e)
        {
            EmployeeCounter++;
            //  dgvAttendance.DataSource = EmployeeDAL.GetAllPatients();
            string commandString = "Select * from Employees";
            OleDbCommand command = new OleDbCommand(commandString, connection);

            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dgvAttendance.DataSource = table;
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
        private void btnAddEmployee_Click(object sender, EventArgs e)
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
        }

        private void btnAddEmployee_Click_1(object sender, EventArgs e)
        {
            string commandString = "Insert into Students(StudentNo, StudentFirstName, StudentLastName) Values('ah0011', 'Ruba', 'Saeed')";
            OleDbCommand command = new OleDbCommand(commandString, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
