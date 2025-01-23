using Microsoft.AspNetCore.Mvc;

namespace VulnerableSite.Controllers;

public class CorsController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        Response.Headers.AccessControlAllowOrigin = Request.Headers.Origin.Count != 0 ? Request.Headers.Origin : "*";
        return View();
    }
}
