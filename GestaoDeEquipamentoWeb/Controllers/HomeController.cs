using Microsoft.AspNetCore.Mvc;

namespace GestaoDeEquipamentosWeb.ConsoleApp.Controllers;
public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View();
    }

}
