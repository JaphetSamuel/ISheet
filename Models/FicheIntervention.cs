namespace ISheet.Models;

public record class FicheIntervention (
    int Id,
    String Auteur,
    DateOnly DateCreation,
    String Status
) {
    String Path = "generated_url";
};