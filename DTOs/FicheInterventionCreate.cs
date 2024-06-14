namespace ISheet.Dtos;

public record class FicheInterventionCreate (
    String Auteur,
    DateOnly DateCreation,
    String Status
);