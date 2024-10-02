using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineStudentManagementSystemProject.Models;

namespace OnlineStudentManagementSystemProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private SchoolContext _context;
        public StudentController(SchoolContext context) {

            _context = context;

        }


        [HttpGet]
        public IEnumerable<Student> GetStudents() { 
            return _context.Students;
        }
    }
}
