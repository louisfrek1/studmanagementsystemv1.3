using MySql.Data.MySqlClient;
using studmanagementsystemv13.Models;

namespace studmanagementsystemv13.Models
{
    public class InstructorContext
    {
        private readonly MySqlConnection _mySqlConnection;

        public InstructorContext(string connectionString)
        {
            _mySqlConnection = new MySqlConnection(connectionString);
        }

        public bool InsertInstructor(Instructor instructor)
        {
            try
            {
                _mySqlConnection.Open();
                MySqlCommand command = new MySqlCommand(

                    @"INSERT INTO instructors (lname,fname,mname,suffix,stadd,city,province,bdate,pnum,email)
                        VALUES(@lname,@fname,@mname,@suffix,@stadd,@city,@province,@bdate,@pnum,@email)", _mySqlConnection);
                command.Parameters.AddWithValue("@lname", instructor.LName);
                command.Parameters.AddWithValue("@fname", instructor.FName);
                command.Parameters.AddWithValue("@mname", instructor.MName);
                command.Parameters.AddWithValue("@suffix", instructor.Suffix);
                command.Parameters.AddWithValue("@stadd", instructor.Streetadd);
                command.Parameters.AddWithValue("@city", instructor.City);
                command.Parameters.AddWithValue("@province", instructor.State);
                command.Parameters.AddWithValue("@bdate", instructor.BDate);
                command.Parameters.AddWithValue("@pnum", instructor.PNum);
                command.Parameters.AddWithValue("@email", instructor.EAdd);

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
