using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HR_Manager_AD0667
{
    public partial class frmAddEmolpyees : Form
    {
        private int StudentCounter = 0;

        private List<Employee> employees = new List<Employee>();

        // list to hold all the degree
        static List<string> addDegree = new List<string>();
        BindingSource AddDegreeBindingSource = new BindingSource();

        public frmAddEmolpyees()
        {
            InitializeComponent();
            AddDegreeBindingSource.DataSource = addDegree;
            lstCertificate.DataSource = AddDegreeBindingSource;
        }
        private void btnAddDegree_Click(object sender, EventArgs e)
        {
            frmAddDegree frmAddDegree = new frmAddDegree();
            frmAddDegree.ShowDialog();
            this.Show();
        }
        internal void receiveData(string degree)
        {
            addDegree.Add(degree);
            AddDegreeBindingSource.ResetBindings(false);
           // MessageBox.Show("iteat " + addDegree.Count);
        }
        private void frmNavigation_Activated(object sender, EventArgs e)
        {
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "a->z")
            {
                addDegree.Sort();
                AddDegreeBindingSource.ResetBindings(false);
            }
            else
            {
                addDegree.Sort();
                addDegree.Reverse();
                AddDegreeBindingSource.ResetBindings(false);
            }
        }
      /*  private void lstAddDegree_Click(object sender, EventArgs e)
        {
           /* ListBox listBox = (ListBox)sender;
            int i = lstCertificate.SelectedIndex;
            if (i >= 0)
            {
                DialogResult result = MessageBox.Show("Would you like to delete "
                 + listBox.Items[i] + " ?", "Confim Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    addDegree.RemoveAt(listBox.SelectedIndex);
                    AddDegreeBindingSource.ResetBindings(false);
                }
            }  
        }*/

        private void frmNavigation_Load(object sender, EventArgs e)
        {
            // set the data source for the binding
            AddDegreeBindingSource.DataSource = addDegree;
            // set the binding to the listbox
            lstCertificate.DataSource = AddDegreeBindingSource;
            StudentCounter++;
            txtEmployeeDi.Text = "EMP2022_" + StudentCounter;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee();
            newEmployee.EmpId = txtEmployeeDi.Text;
            newEmployee.Name = txtEmployeeName.Text;
           // newEmployee.DateOfBirth = dtpEmployeeDOB.Value;
           // newEmployee.Certificate = lstCertificate.SelectedItem.ToString();
           // MessageBox.Show("Employee added successfully \n" + newEmployee.EmployeeReport());
            employees.Add(newEmployee);
            ClearScreen();
        }
        private void ClearScreen()
        {
            StudentCounter++;
            txtEmployeeDi.Text = "EMP2022_" + StudentCounter;
            txtEmployeeName.Text = string.Empty;
            dtpEmployeeDOB.Value = DateTime.Now;
            lstCertificate.SelectedIndex = 0;
            txtEmployeeName.Focus();
        }
    }
}
