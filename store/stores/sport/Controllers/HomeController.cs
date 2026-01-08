using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using stores.sport.Models;


namespace stores.sport.Controllers;

public class HomeController : Controller
{
    private IHubConnection repository;

    public HomeController(IHubConnection repo)
    {
        repository = repo;
    }


    public IActionResult Index()
    {
        return View(repository.Products.ToList());
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }


}
