using Microsoft.AspNetCore.Mvc;
namespace BasicWebApp.Controllers;
using Services;


public class StudentController : Controller
{
    public IActionResult Index([FromServices]Services.IDbContext obj)
    {
        ViewBag.Course=obj.Courses;
        return View("Courses");
    }
    [HttpPost]
    public IActionResult Details(int Cid, [FromServices]Services.IDbContext obj)
    {
        var man=obj.Courses
                .Where(c=>c.Id==Cid)
                .Include(c=>c.Students)
                .FirstOrDefault();
        ViewBag.students=man.Students;
        return View ("Student");
    }
}