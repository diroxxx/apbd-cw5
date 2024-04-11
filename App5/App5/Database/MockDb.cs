using App5.Models;

namespace App5.Database;

public class MockDb
{
    public List<Animal> Animals { get; set; } = new List<Animal>();

    public MockDb()
    {
        Animals.Add(new Animal(1,"Antylopa", "ssak", 150, "brazowa"));
        Animals.Add(new Animal(2, "krowa", "ssak", 700, "biala"));
        Animals.Add(new Animal(3, "pies", "ssak", 40, "czarny"));
    }
}