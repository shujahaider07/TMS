using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TMS.DbContextClass;

namespace TMS.Controllers
{
    [Authorize(Roles = "Admin")]
    public class StudentController : Controller
    {
        private readonly ApplicationDBContext _context;
        public StudentController(ApplicationDBContext _context)
        {
            this._context = _context;
        }

        public IActionResult GetStudents()
        {
            var studentsList = _context.students
                .ToList();
            return View(studentsList);
        }
    }
}
