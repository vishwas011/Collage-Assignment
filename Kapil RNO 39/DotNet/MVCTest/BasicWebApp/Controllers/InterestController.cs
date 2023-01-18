namespace BasicWebApp.Controllers;

public class InterestController : Controller
{
    public IActionResult Index(string id)
    {
        ViewBag.GuestName = id ?? "Visitor";
        return View("Form");
    }
     
     public IActionResult Simple(double Principal, int Rate, int Years, [FromServices] BasicWebApp.Services.ICalculate counter)
     {
        ViewBag.simple= counter.SiCalculate(Principal, Rate, Years);
        return View("Result");
     }
}