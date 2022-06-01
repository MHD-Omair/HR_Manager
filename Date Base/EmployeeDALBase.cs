using System.Data.OleDb;

namespace HR_Manager_AD0667
{
    public static class EmployeeDALBase
    {
        public static Employee GetEmployeeById(int id)
        {
            Employee employee = new Employee();

            string commandString = string.Format("Select * from Employee where EmployeeId = {0}", id);

            OleDbCommand command = new OleDbCommand(commandString, connection);

            connection.Open();

            OleDbDataReader EmployeeReader = command.ExecuteReader();

            if (EmployeeReader.HasRows)
            {
                while (EmployeeReader.Read())
                {
                    Employee.EmployeeId = EmployeeReader.GetInt32(0);
                    Employee.EmployeeName = EmployeeReader.GetString(1);
                }
            }
            connection.Close();
            return Employee;
        }
    }
}