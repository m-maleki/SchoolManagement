using System.Data.SqlClient;
using Core.Student.Contracts;
using Core.Student.Model;
using Core.Student.Scripts;

namespace Ado.net.QueryServices;
public class StudentQueryServices : IStudentQueryServices
{
    private const string ConnectionString = "Data Source=MASOUD;Initial Catalog=Database-Maktab;User ID=sa;Password=25915491;TrustServerCertificate=True";
    public void Create(StudentAddDto model)
    {
        var connection = new SqlConnection(ConnectionString);
        connection.Open();

        var query =
            string.Format(SqlScripts.Add, model.FirstName, model.LastName, model.Age, model.PhoneNumber);

        var command = new SqlCommand(query, connection);

        command.ExecuteNonQuery();

        connection.Close();
    }
    public void Delete(int id)
    {
        var connection = new SqlConnection(ConnectionString);
        connection.Open();

        var query = string.Format(SqlScripts.Delete, id);

        var command = new SqlCommand(query, connection);
       
        command.ExecuteNonQuery();

        connection.Close();
    }
    public StudentDto Get(int id)
    {
        var result = new StudentDto();

        var connection = new SqlConnection(ConnectionString);
        connection.Open();

        var query = string.Format(SqlScripts.Get, id);

        var command = new SqlCommand(query, connection);
        
        var reader = command.ExecuteReader();

        while (reader.Read())
        {
            result.Id = (int)reader["Id"];
            result.FirstName = (string)reader["FirstName"];
            result.LastName = (string)reader["LastName"];
            result.Age = (int)reader["Age"];
            result.PhoneNumber = (string)reader["PhoneNumber"];
        }

        connection.Close();

        return result;
    }
    public List<StudentDto> GetAll()
    {
        var result = new List<StudentDto>();

        var connection = new SqlConnection(ConnectionString);
        connection.Open();

        var query = string.Format(SqlScripts.GetAll);

        var command = new SqlCommand(query, connection);
       
        var reader = command.ExecuteReader();

        while (reader.Read())
        {
            result.Add(new StudentDto
            {
                Id = (int)reader["Id"],
                FirstName = (string)reader["FirstName"],
                LastName = (string)reader["LastName"],
                Age = (int)reader["Age"],
                PhoneNumber = (string)reader["PhoneNumber"]
            });
        }

        connection.Close();

        return result;
    }
}

