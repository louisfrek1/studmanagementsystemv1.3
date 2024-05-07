using MySql.Data.MySqlClient;
using studmanagementsystemv13.Models;

namespace studmanagementsystemv13.Models
{
    public class CourseContext
    {
        private readonly MySqlConnection _mySqlConnection;

        public CourseContext(string connectionString)
        {
            _mySqlConnection = new MySqlConnection(connectionString);
        }

        public bool InsertCourse(Course course)
        {
            try
            {
                _mySqlConnection.Open();
                MySqlCommand command = new MySqlCommand(

                    @"INSERT INTO courseni (coursecode,title,lecture,laboratory,description)
                        VALUES(@coursecode,@title,@lecture,@laboratory,@description)", _mySqlConnection);
                command.Parameters.AddWithValue("@coursecode", course.Code);
                command.Parameters.AddWithValue("@title", course.Title);
                command.Parameters.AddWithValue("@lecture", course.Lecture);
                command.Parameters.AddWithValue("@laboratory", course.Laboratory);
                command.Parameters.AddWithValue("@description", course.Description);

                int rowsAffected = command.ExecuteNonQuery();
                _mySqlConnection.Close();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

    }
}
