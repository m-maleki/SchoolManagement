using Core.Student.Model;

namespace Core.Student.Contracts;
public interface IStudentQueryServices
{
    void Create(StudentAddDto model);
    void Delete(int id);
    StudentDto Get(int id);
    List<StudentDto> GetAll();
}