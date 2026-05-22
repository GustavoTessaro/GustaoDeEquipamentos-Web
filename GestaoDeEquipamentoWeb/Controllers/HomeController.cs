using Microsoft.AspNetCore.Mvc;

namespace GestaoDeEquipamentoWeb.Controllers;
public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View();
    }

}

