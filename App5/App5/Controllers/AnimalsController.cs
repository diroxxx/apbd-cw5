using App5.Database;
using App5.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace App5.Controllers;


[ApiController]
[Route("/animals_controller")]
public class AnimalsController : ControllerBase
{
    private MockDb _mockDb;

    public AnimalsController(MockDb mockDb)
    {
        _mockDb = mockDb;
    }
    
    
    [HttpGet("/getListOfAnimals")]
    public IActionResult GetAnimalsList()
    {
        return Ok(_mockDb.Animals);
    }

    [HttpGet("/GetAnimalById{id}")]
    public IActionResult GetAnimalById(int id)
    {
        var tmp = _mockDb.Animals.Find(a => a.Id == id);
        if (tmp == null)
        {
            return NotFound();
        }

        return Ok(tmp);
    }
    
    
    [HttpPost("/AddAnimal")]
    public IActionResult AddAnimal(Animal animal)
    {
        if (_mockDb.Animals.Any(a => a.Id == animal.Id))
        {
            return Conflict("Id is already in database, try diffrent one");
        }
        _mockDb.Animals.Add(animal);
        
        return Created("", animal);
    }

    [HttpPut("/editAnimal")]
    public IActionResult EditAnimal([FromBody]Animal animal)
    {
        var tmp = _mockDb.Animals.
            Find(a => a.Id == animal.Id);
        if (tmp == null)
        {
            return NotFound();
        }

        tmp.Name = animal.Name;
        tmp.Type = animal.Type;
        tmp.Color = animal.Color;

        // animals.Remove(tmp);
        // animals.Add(animal);
        // return Ok(animal);

        return Ok(tmp);
    }

    [HttpDelete("/deleteAnimalById/{id}")]
    public IActionResult DeleteAnimalById(int id)
    {
        var tmp = _mockDb.Animals.
            Find(a => a.Id == id);
        
        if (tmp == null)
        {
            return NotFound();
        }

        _mockDb.Animals.Remove(tmp);
        return Ok();


    }
    
    
}