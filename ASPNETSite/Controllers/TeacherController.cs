using ASPNETSite.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPNETSite.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDBContext _dbContext;

        public TeacherController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var teachers = _dbContext.Teachers.Include(x => x.TeacherGroups).ThenInclude(x=>x.Group).ToList();
            return View(teachers);
        }
    }
}
