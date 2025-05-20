using StudentAdminPortal.DataModels;

namespace StudentAdminPortal.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudents();
    }
}
