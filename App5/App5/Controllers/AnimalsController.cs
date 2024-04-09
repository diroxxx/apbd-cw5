using App5.Database;
using Microsoft.AspNetCore.Mvc;

namespace App5.Controllers;


[ApiController]
[Route("/animals-controller")]
public class AnimalsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = new MockDb().Animals;
        return Ok(animals);
    }
    
    [HttpPost]
    public IActionResult AddAnimals()
    {
        return Created();
    }
}