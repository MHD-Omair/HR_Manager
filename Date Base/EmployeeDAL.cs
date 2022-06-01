using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace HR_Manager_AD0667
{
    public static class EmployeeDAL
    {
        private static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
        "Data Source=C:\\Users\\mhdom\\OneDrive\\Desktop\\UI\\برمجة مرئية\\HR_Manager_AD0667-master\\DataBase";

        public static OleDbConnection connection = new OleDbConnection(connectionString);
        public static DataTable GetAllEmployee()
        {
            string commandString = "Select * from Employees";

            OleDbCommand command = new OleDbCommand(commandString, connection);

            OleDbDataAdapter da = new OleDbDataAdapter(command);

            DataTable EmployeesTable = new DataTable();

            da.Fill(EmployeesTable);

            return EmployeesTable;
        }
        public static Employee GetEmployeeById(int id)
        {
            Employee employee = new Employee();
            string commandString = string.Format("Select * from Employees where EmployeeId = {0}", id);

            OleDbCommand command = new OleDbCommand(commandString, connection);
            connection.Open();
            OleDbDataReader EmployeeReader = command.ExecuteReader();
          /* if (EmployeeReader.HasRows)
            {
                while (EmployeeReader.Read())
                {
                    Employee.EmployeeId = EmployeeReader.GetInt32(0);
                    Employee.EmployeeName = EmployeeReader.GetString(1);
                }
            }
            connection.Close();
            return Employee;*/
        }
        /*public static void CreateEmployee(Employee employee)
        {
            string commandString = string.Format("Insert into Employees(EmployeetName) values('{0}')", Employee.EmployeeName);
            OleDbCommand command = new OleDbCommand(commandString, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static void UpdateEmployee(Employee employee)
        {
            string commandString = string.Format("Update Employees Set EmployeeName = '{0}'",Employee.EmployeeName);
            OleDbCommand command = new OleDbCommand(commandString, connection);
            connection.Close();

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static void DeleteEmployee(int id)
        {
            string commandString = string.Format("Delete from Employees where EmployeeId = {0}",id);
            OleDbCommand command = new OleDbCommand(commandString, connection);
            connection.Close();

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }*/
    }
}
