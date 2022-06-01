using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Manager_AD0667
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
       // public DateTime DateOfBirth { get; set; }
       // public string Certificate { get; set; }

        public Employee()
        {

        }
        public Employee(int empId, string name, DateTime dateTime, string certificate)
        {
            this.EmployeeId = empId;
            this.EmployeeName = name;
            //this.DateOfBirth = dateTime;
           // this.Certificate = certificate;
        }
        public string EmployeeReport()
        {
            string report = "Employee ID : " + EmployeeId + "\nEmployee : " + EmployeeName /*+ "\nEmployee DOB : " 
                + DateOfBirth.ToShortDateString() + "\nEmployee Certificate : " + Certificate*/;

            return report;
        }
    }
}
