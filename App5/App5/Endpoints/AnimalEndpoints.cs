namespace App5.Endpoints;

public static class AnimalEndpoints
{
    public static void MapAnimalEndpoints(this WebApplication app)
    {
        //minimal api
        app.MapGet("/animals/{id}", (int id) =>
        {
            return Results.Ok(id);

        });
        app.MapPost("/animals", () =>
        {
            return Results.Created();
        });
    }
}