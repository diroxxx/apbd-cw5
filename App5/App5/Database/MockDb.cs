using App5.Models;

namespace App5.Database;

public class MockDb
{
    public List<Animal> Animals { get; set; } = new List<Animal>();
    public List<VeterinaryVisit> ClinicVisits { get; set; } = new List<VeterinaryVisit>();

    public MockDb()
    {
        Animals.Add(new Animal(1,"Antylopa", "ssak", 150, "brazowa"));
        Animals.Add(new Animal(2, "krowa", "ssak", 700, "biala"));
        Animals.Add(new Animal(3, "pies", "ssak", 40, "czarny"));
        
        ClinicVisits.Add(new VeterinaryVisit(
            new DateTime(2024, 4, 10),
            new Animal(1,"Antylopa", "ssak", 150, "brazowa"),
            "without any problems", 124.23));
        
        
    }
}