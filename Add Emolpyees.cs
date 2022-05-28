using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HR_Manager_AD0667
{
    public partial class frmAddEmolpyees : Form
    {
        private int StudentCounter = 0;
        private List<DBEmployee> Employees = new List<DBEmployee>();

        // list to hold all the degree
        static List<string> addDegree = new List<string>();
        BindingSource AddDegreeBindingSource = new BindingSource();

        public frmAddEmolpyees()
        {
            InitializeComponent();

            AddDegreeBindingSource.DataSource = addDegree;
            lstAddDegree.DataSource = AddDegreeBindingSource;
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
            MessageBox.Show("iteat " + addDegree.Count);
        }

        private void frmNavigation_Activated(object sender, EventArgs e)
        {
            AddDegreeBindingSource.ResetBindings(true);
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


        private void lstAddDegree_Click(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            int i = lstAddDegree.SelectedIndex;
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
        }

        private void frmNavigation_Load(object sender, EventArgs e)
        {
            // set the data source for the binding
            AddDegreeBindingSource.DataSource = addDegree;
            // set the binding to the listbox
            lstAddDegree.DataSource = AddDegreeBindingSource;

            StudentCounter++;
            txtEmployeeNo.Text = "EMP_" + StudentCounter;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DBEmployee newEmployee = new DBEmployee();
            newEmployee.EmpId = txtEmployeeNo.Text;
            newEmployee.EmpName = txtEmployeeName.Text;
            newEmployee.EmpNameLast = txtEmployeeLast.Text;

            MessageBox.Show("Employee added successflly \n" + 
                newEmployee.EmployeeReport());
            Employees.Add(newEmployee);
            ClearScreen();
        }
        private void ClearScreen()
        {
            StudentCounter++;
            txtEmployeeNo.Text = "EMP_" + StudentCounter;
            txtEmployeeName.Text = String.Empty;
            txtEmployeeLast.Text = String.Empty;
            lstAddDegree.SelectedIndex = 0;
            txtEmployeeName.Focus();
        }
    }
}
