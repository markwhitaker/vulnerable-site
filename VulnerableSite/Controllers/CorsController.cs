using Microsoft.AspNetCore.Mvc;

namespace VulnerableSite.Controllers;

public class CorsController : Controller
{
    // GET
    public IActionResult Index()
    {
        Response.Headers.AccessControlAllowOrigin = Request.Headers.Origin;
        return View();
    }
}
