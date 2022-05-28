using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;


namespace HR_Manager_AD0667
{
    public partial class frmAttendance : Form
    {
        string _data;

        public frmAttendance()
        {
            InitializeComponent();
        }
        public frmAttendance(string data)
        {
            _data = data;
        }
        private void frmAttendance_Load(object sender, EventArgs e)
        {

        }
        /*BindingList<DBEmployee> list = new BindingList<DBEmployee>();
        public BindingList<DBEmployee> GetAll()
        {

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
                    Data Source=|DataDirectory|\DBAttendance1.accdb;";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string sql = "select * from Mobile";

                OleDbCommand command = new OleDbCommand(sql, connection);
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string id = (string)reader["ID"];
                    string name = (string)reader["Name"];
                    string last = (string)reader["Last Name"];
                    bool Attendance = (bool)reader["Attendance"];

                    list.Add(new DBEmployee()
                    { EmpId = id, EmpName = name, EmpNameLast = last, EmpAttendance = Attendance });
                }

                connection.Close();
            }
            return list;
        }
       /* private DataTable GetAttendanceList()
        {
            DataTable dtAttendance = new DataTable();

            string connString =
            ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (OleDbConnection con = new OleDbConnection(connString))
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM Employees", con))
                {
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    dtAttendance.Load(reader);
                }
            }

            return dtAttendance;
        }*/
    }
}
