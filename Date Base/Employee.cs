using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Manager_AD0667
{
    internal class Employee
    {
        public string EmpId { get; set; }
        public string Name { get; set; }
       // public DateTime DateOfBirth { get; set; }
       // public string Certificate { get; set; }

        public Employee()
        {

        }
       /* public Employee(string empId, string name, DateTime dateTime, string certificate)
        {
            this.EmpId = empId;
            this.Name = name;
            this.DateOfBirth = dateTime;
            this.Certificate = certificate;
        }
        public string EmployeeReport()
        {
            string report = "Employee ID : " + EmpId + "\nEmployee : " + Name + "\nEmployee DOB : " 
                + DateOfBirth.ToShortDateString() + "\nEmployee Certificate : " + Certificate;

            return report;
        }*/
    }
}
