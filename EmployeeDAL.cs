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
        private static string connectionString = "Provideer=Microsoft.ACE.OLEDB.12.0;" +
        "Data Source=C:\\Users\\mhdom\\OneDrive\\Desktop\\UI\\برمجة مرئية\\HR_Manager_AD0667-master\\DataBase";

        public static OleDbConnection connection = new OleDbConnection(connectionString);
        public static DataTable GetAllEmployee()
        {
            string commandString = "Select * form Employee";

            OleDbCommand command = new OleDbCommand(connectionString, connection);
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable EmployeeTable = new DataTable();
            da.Fill(EmployeeTable);

            return EmployeeTable;
        }
        public static Employee GetEmployee(int id)
        {
            return null;
        }
        public static void CreatEmployee(Employee employee)
        {
            string commandString = string.Format(
            "Insert into Employee (EmployeeName) Values('{0}')",employee.Name);
            OleDbCommand command = new OleDbCommand(connectionString, connection);
            connection.Close();           
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static void UpdateEmployee(Employee employee)
        {
            string commandString = string.Format(
                        "Update into Employee (EmployeeName) Values('{0}')", employee.Name);
            OleDbCommand command = new OleDbCommand(connectionString, connection);
            connection.Close();
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
