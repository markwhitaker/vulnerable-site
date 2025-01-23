using Microsoft.AspNetCore.Mvc;
using VulnerableSite.Models;
using VulnerableSite.Services;

namespace VulnerableSite.Controllers;

public class XssController(IXssService xssService) : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new XssViewModel(xssService.Messages);
        return View(model);
    }

    [HttpPost]
    public IActionResult Add([FromForm] string message)
    {
        xssService.AddMessage(message);
        return RedirectToAction("Index");
    }
}
