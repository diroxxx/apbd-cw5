using App5.Database;
using App5.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace App5.Controllers;


[ApiController]
[Route("/animals-controller")]
public class AnimalsController : ControllerBase
{
    [HttpGet("/getListOfAnimals")]
    public IActionResult GetAnimalsList()
    {
        var animals = new MockDb().Animals;
        return Ok(animals);
    }

    [HttpGet("{id}")]
    public IActionResult GetAnimalById(int id)
    {
        var animals = new MockDb().Animals;
        var tmp = animals.Find(a => a.Id == id);
        if (tmp == null)
        {
            return NotFound();
        }

        return Ok(tmp);
    }
    
    
    [HttpPost("/AddAnimal")]
    public IActionResult AddAnimal(Animal animal)
    {
        var animals = new MockDb().Animals;
        animals.Add(animal);
        return Created("", animal);
    }

    [HttpPut("/editAnimal")]
    public IActionResult EditAnimal([FromBody]Animal animal)
    {
        var animals = new MockDb().Animals;
        var tmp = animals.Find(a => a.Id == animal.Id);
        if (tmp == null)
        {
            return NotFound();
        }

        animals.Remove(tmp);
        animals.Add(animal);
        return Ok(animal);



    }
}