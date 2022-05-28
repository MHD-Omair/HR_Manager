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
        public DateTime DateTime { get; set; }
        public string Certificate { get; set; }

        public Employee(string empId, string name, DateTime dateTime, string certificate)
        {
            EmpId = empId;
            Name = name;
            DateTime = dateTime;
            Certificate = certificate;
        }
        public Employee()
        {

        }
    }
}
