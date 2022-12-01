using Microsoft.AspNetCore.Mvc;
namespace Portfolio.Controllers;

public class PortfolioController : Controller
{
    // Routing
    [HttpGet("")]
    public ViewResult Index()
    {
        return View("Index");
    }
    [HttpGet("projects")]
    public ViewResult Projects()
    {
        return View("Projects");
    }
    [HttpGet("contact")]
    public ViewResult Contact()
    {
        return View("contact");
    }

    [HttpPost("process")]
    public IActionResult Process(string MyContacts)
    {
        return Redirect("/");
    }

}