namespace App5.Models;

public class VeterinaryVisit
{
    public DateTime DateOfvisit { get; set; }
    public Animal Animal { get; set; }
    public string DescVisit { get; set; }
    public Double price { get; set; }

    public VeterinaryVisit(DateTime dateOfvisit, Animal animal, string descVisit, double price)
    {
        DateOfvisit = dateOfvisit;
        Animal = animal;
        DescVisit = descVisit;
        this.price = price;
    }
}