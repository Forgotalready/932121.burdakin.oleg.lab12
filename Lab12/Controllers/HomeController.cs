using Microsoft.AspNetCore.Mvc;

namespace Lab12.Controllers;

public class HomeController : Controller
{ 
  public IActionResult Index() => View();
}