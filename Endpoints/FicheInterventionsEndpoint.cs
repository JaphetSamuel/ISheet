using ISheet.Dtos;

public static class FicheInterventionEndpoints
{

    private static List<FicheIntervention> fiches = [
        new (1,"japhet",new DateOnly(2024,06,12),"Termine"),
        new (2,"Silver",new DateOnly(2024,06,07),"Termine"),
        ];

    public static WebApplication MapFicheIntervention(this WebApplication app)
    {
        var group = app.MapGroup("/FicheInterventions")
        .WithOpenApi()
        .WithParameterValidation();

        // GET FicheInterventions/
        group.MapGet("/", () =>
        {
            return Results.Ok<List<FicheIntervention>>(fiches);
        });

        // GET FicheIntervention/1
        group.MapGet("/{id}", (int id) =>
        {
            var fiche = fiches.Find(f => f.Id == id);

            if (fiche is null)
            {
                return Results.NotFound();
            }

            return Results.Ok(fiche);
        })
        .WithName("GetFicheIntervention");

        // POST FicheIntervention
        group.MapPost("/", (FicheInterventionCreate fiche) =>
        {
            var newFiche = new FicheIntervention(
                fiches.Count + 1,
                fiche.Auteur,
                fiche.DateCreation,
                fiche.Status
            );

            fiches.Add(newFiche);

            return Results.CreatedAtRoute("GetFicheIntervention", new { id = newFiche.Id }, newFiche);

        });

        // PUT ficheINterventions/1
        group.MapPut("/{id}", (FicheIntervention fiche, int id)=>{

            var index = fiches.FindIndex(f => f.Id == id);

            if(index == -1) {
                return Results.NotFound();
            }

            fiches[index] = new FicheIntervention(
                id,fiche.Auteur,fiche.DateCreation,fiche.Status
            );

            return Results.NoContent();

        });

        return app;
    }
}