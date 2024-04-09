using App5.Database;
using App5.Models;

namespace App5.Endpoints;

public static class AnimalEndpoints
{
    public static void MapAnimalEndpoints(this WebApplication app)
    {
        //minimal api
        app.MapGet("/animals/{id}", (int id) =>
        {
            var animals = StaticData.Animals;
            return Results.Ok(animals);

        });
        app.MapPost("/animals", (Animal Animal) =>
        {
            return Results.Created("", Animal);
        });
    }
}