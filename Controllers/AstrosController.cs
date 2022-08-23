using Microsoft.AspNetCore.Mvc;

namespace Astromedia_admin.Controllers;

public class AstrosController : Controller
{

    public IActionResult Index()
    {
        return View();
    }
}
