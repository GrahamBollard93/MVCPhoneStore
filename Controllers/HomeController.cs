using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PhoneStore.Models;
using PhoneStore.Service;

namespace PhoneStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly PhoneApiService _phoneApiService;

    public HomeController(ILogger<HomeController> logger, PhoneApiService phoneApiService)
    {
        _logger = logger;
        _phoneApiService = phoneApiService;
    }

    public IActionResult Index()
    {
        return View();
    }

     public IActionResult Phones()
    {
        return View(_phoneApiService.GetProducts());
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
