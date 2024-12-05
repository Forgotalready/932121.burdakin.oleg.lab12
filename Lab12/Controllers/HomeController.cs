using Microsoft.AspNetCore.Mvc;

namespace Lab12.Controllers;

public sealed class HomeController : Controller
{ 
  public IActionResult Index() => View();
}