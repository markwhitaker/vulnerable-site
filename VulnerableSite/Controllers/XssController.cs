using Microsoft.AspNetCore.Mvc;
using VulnerableSite.Models;
using VulnerableSite.Services;

namespace VulnerableSite.Controllers;

public class XssController : Controller
{
    private readonly IXssService _xssService;

    public XssController(IXssService xssService)
    {
        _xssService = xssService;
    }

    // GET
    public IActionResult Index()
    {
        var model = new XssViewModel(_xssService.Messages);

        return View(model);
    }

    [HttpPost]
    public IActionResult Add([FromForm] string message)
    {
        _xssService.AddMessage(message);

        return RedirectToAction("Index");
    }
}
