using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<RecipesDB>(
    opt => opt.UseSqlServer("Server=.;Initial Catalog=TasteBuds;User Id=TestUser; Password=passwd;Trusted_Connection=True;TrustServerCertificate=True"));

var app = builder.Build();

app.MapGet("/recipe", async (RecipesDB db) =>
    await db.Recipe.ToListAsync());

app.MapGet("/recipe/{id}", async (int id, RecipesDB db) =>
    await db.Recipe.FindAsync(id)
        is Recipes recipe
            ? Results.Ok(recipe)
            : Results.NotFound());

app.MapPost("/recipe", async (Recipes recipe, RecipesDB db) =>
{
    db.Recipe.Add(recipe);
    await db.SaveChangesAsync();

    return Results.Created($"/recipe/{recipe.Recipe_id}", recipe);
});

app.MapPut("/recipe/{id}", async (int id, Recipes inputRecipe, RecipesDB db) =>
{
    var recipe = await db.Recipe.FindAsync(id);

    if (recipe is null) return Results.NotFound();

    recipe.Recipe_name = inputRecipe.Recipe_name;

    await db.SaveChangesAsync();

    return Results.NoContent();
});

app.MapDelete("/recipe/{id}", async (int id, RecipesDB db) =>
{
    if (await db.Recipe.FindAsync(id) is Recipes recipe)
    {
        db.Recipe.Remove(recipe);
        await db.SaveChangesAsync();
        return Results.NoContent();
    }

    return Results.NotFound();
});

app.Run();