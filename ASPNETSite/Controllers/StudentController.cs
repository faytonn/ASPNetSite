using ASPNETSite.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPNETSite.Controllers
{
    public class StudentController:Controller
    {
        private readonly AppDBContext _dbContext;

        public StudentController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var students = _dbContext.Students.Include(x => x.Group).ToList();
            return View(students);
        }
    }
}
