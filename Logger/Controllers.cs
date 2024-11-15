using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    private readonly ICustomLogger _logger;

    public HomeController(ICustomLogger logger)
    {
        _logger = logger;
    }

    [HttpGet("index")]
    public IActionResult Index()
    {
        _logger.LogInformation("API index sahifasi chaqirildi.");
        return Ok("Salom, API ishlayapti!");
    }

    [HttpGet("error")]
    public IActionResult Error()
    {
        _logger.LogError("API xatolik yuz berdi.");
        return Problem("Xatolik yuz berdi!");
    }

    private IActionResult Problem(string v)
    {
        throw new NotImplementedException();
    }
}
