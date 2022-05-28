using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Manager_AD0667
{
    internal class DBEmployee
    {
        public string EmpId { set; get; }
        public string EmpName { set; get; }
        public string EmpNameLast { set; get; }

        public bool EmpAttendance { set; get; }

        public DBEmployee()
        {
            
        }
        public DBEmployee
        (string empId,string empName,string empLast, bool attendance)
        {
            EmpId = empId;
            EmpName = empName;
            EmpNameLast = empLast;
            EmpAttendance = attendance;

        }

        internal string EmployeeReport()
        {
            throw new NotImplementedException();
        }
    }

}
