using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SekaiNoTabi.WEB.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SekaiNoTabi.WEB.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IMongoCollection<Destination> _destinations;

    public HomeController(ILogger<HomeController> logger, IMongoDatabase database)
    {
        _logger = logger;
        _destinations = database.GetCollection<Destination>("Destinations");
    }

    public IActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> Destination()
    {
        var destinations = await _destinations.Find(destination => true).ToListAsync();
        return View(destinations);
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