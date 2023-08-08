using System.Data.SqlClient;
using System.Reflection;
using Core.Student.Contracts;
using Core.Student.Model;
using Core.Student.Scripts;
using Dapper;

namespace Infra.Dapper.QueryServices;
public class StudentQueryServices : IStudentQueryServices
{
    private const string ConnectionString = "Data Source=MASOUD;Initial Catalog=Database-Maktab;User ID=sa;Password=25915491;TrustServerCertificate=True";

    public void Create(StudentAddDto model)
    {
        var connection = new SqlConnection(ConnectionString);

        var query = 
            string.Format(SqlScripts.Add, model.FirstName, model.LastName, model.Age, model.PhoneNumber);
       
        connection.Query<StudentDto>(query);
    }
    public void Delete(int id)
    {
        var connection = new SqlConnection(ConnectionString);
        
        var query = string.Format(SqlScripts.Delete, id);
        
        connection.Query<StudentDto>(query);
    }
    public StudentDto Get(int id)
    {
        var connection = new SqlConnection(ConnectionString);
      
        var query = string.Format(SqlScripts.Get, id);
        
        var result = connection.Query<StudentDto>(query);

        return result.First();

    }
    public List<StudentDto> GetAll()
    {
        var connection = new SqlConnection(ConnectionString);

        var query = string.Format(SqlScripts.GetAll);
        
        var result = connection.Query<StudentDto>(query);

        return result.ToList();
    }
}