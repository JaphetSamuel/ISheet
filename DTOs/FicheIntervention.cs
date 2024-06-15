using System.ComponentModel.DataAnnotations;

namespace ISheet.Dtos;

public record class FicheIntervention(
    [Required] int Id,
    [Required] String Auteur,
    DateOnly DateCreation,
    String Status
)
{
    String Path = "generated_url";
};