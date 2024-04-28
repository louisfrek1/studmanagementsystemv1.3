using MySql.Data.MySqlClient;

namespace studmanagementsystemv1._3.Models
{
    public class StudentContext
    {
        public readonly MySqlConnection _mySqlConnection;

        public StudentContext(string connectionString)
        {
            _mySqlConnection = new MySqlConnection(connectionString);
        }

        public bool InsertStudent(Students students)
        {
            try
            {
                _mySqlConnection.Open();
                MySqlCommand command = new MySqlCommand(
                    
                    @"INSERT INTO studenttableni (studentname)
                        VALUES(@studentname)", _mySqlConnection);
                command.Parameters.AddWithValue("@studentname", students.Name);

                int rowsAffected = command.ExecuteNonQuery();
                _mySqlConnection.Close();

                return rowsAffected > 0;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
