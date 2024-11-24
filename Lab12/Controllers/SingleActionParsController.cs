using Lab12.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab12.Controllers;

public class SingleActionParsController : Controller
{
  // Один action с разными парметрами.
  [HttpGet]
  public IActionResult Index()
  {
    NumberViewModel numberViewModel = new NumberViewModel{
        NumberModel = new NumberModel(),
        Title = "SingleActionPars",
        ActionName = "Index",
        ControllerName = "SingleActionPars"
    };
    return View("Form", numberViewModel);
  }

  [HttpPost]
  public IActionResult Index(NumberViewModel numberViewModel) 
  {
    if (ModelState.IsValid)
    {
      numberViewModel.NumberModel.Calculate();
    }

    return View("Form", numberViewModel);
  }
}