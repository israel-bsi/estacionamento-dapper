using Microsoft.AspNetCore.Mvc;

namespace Estacionamento.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();
}