using App5.Database;
using App5.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace App5.Controllers;

[ApiController]
[Route("/clinic_controller")]
public class ClinicController : ControllerBase
{
    private MockDb _mockDb;

    public ClinicController(MockDb mockDb)
    {
        _mockDb = mockDb;
    }

    [HttpGet("/ListOfAnimalVisits{id}")]
    public IActionResult GetListOfVisitsSpecificAnimal(int id)
    {
        List<VeterinaryVisit> veterinaryVisits = new List<VeterinaryVisit>();
        
        var visits = _mockDb.ClinicVisits.
            FindAll(a => a.Animal.Id == id);
        if (visits == null)
        {
            return NotFound();
        }

        return Ok(visits);
    }

    [HttpPost("/AddVisits")]
    public IActionResult AddVisits(VeterinaryVisit visit)
    {
        _mockDb.ClinicVisits.Add(visit);
        return Created("", visit);
    }
    
    
    
}
