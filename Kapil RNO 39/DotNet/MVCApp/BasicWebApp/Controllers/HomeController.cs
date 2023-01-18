using BasicWebApp.Services;
using Microsoft.AspNetCore.Mvc;
namespace BasicWebApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index([FromServices] BasicWebApp.Services.StudentDbContext model)
    {
        //var model = new StudentDbContext();
        return View(model);
    }

    [HttpGet]
    [Route("Details/{id:int}")]
    public IActionResult Details(int id)
    {
        var db = new StudentDbContext();
        var cid = id;
        ViewBag.cid = cid;
        var crs = db.CourseInfo
                    .Where(p => p.Id == cid)
                    .Include(p => p.StudentInfo)
                    .FirstOrDefault();
        return View(crs);
    }
}