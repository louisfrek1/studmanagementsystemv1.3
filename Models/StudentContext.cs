using MySql.Data.MySqlClient;

namespace studmanagementsystemv13.Models
{
    public class StudentContext
    {
        private readonly MySqlConnection _mySqlConnection;

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
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool InsertStudentni(Students students)
        {
            try
            {
                _mySqlConnection.Open();
                MySqlCommand command = new MySqlCommand(

                    @"INSERT INTO studentni (lname, fname, mname, suffix, streetadd, city,
                                             state, bdate, gender, pnumber, email, ylevel, degree)
                        VALUES(@lname, @fname, @mname, @suffix, @streetadd, @city,
                                             @state, @bdate, @gender, @pnumber, @email, @ylevel, @degree)", _mySqlConnection);
                command.Parameters.AddWithValue("@lname", students.LName);
                command.Parameters.AddWithValue("@fname", students.FName);
                command.Parameters.AddWithValue("@mname", students.MName);
                command.Parameters.AddWithValue("@suffix", students.Suffix);
                command.Parameters.AddWithValue("@streetadd", students.Streetadd);
                command.Parameters.AddWithValue("@city", students.City);
                command.Parameters.AddWithValue("@state", students.State);
                command.Parameters.AddWithValue("@bdate", students.BDate);
                command.Parameters.AddWithValue("@gender", students.Gender);
                command.Parameters.AddWithValue("@pnumber", students.PNum);
                command.Parameters.AddWithValue("@email", students.EAdd);
                command.Parameters.AddWithValue("@ylevel", students.YLevel);
                command.Parameters.AddWithValue("@degree", students.Degree);

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
