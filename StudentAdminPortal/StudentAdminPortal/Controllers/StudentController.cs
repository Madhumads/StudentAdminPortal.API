using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPortal.DataModels;
using StudentAdminPortal.Repositories;

namespace StudentAdminPortal.Controllers
{
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;

        public StudentController(IStudentRepository studentRepository, IMapper mapper)
        {
            this.studentRepository = studentRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllStudents()
        {
            var students = await studentRepository.GetStudents();

                   
            
            return Ok(mapper.Map<List<Student>>(students));
        }
    }
}
