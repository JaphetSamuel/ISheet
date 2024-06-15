using ISheet.Enums;

namespace  ISheet.Entities;

class FicheIntervention {

    public int Id { get; set; }

    public required String Auteur { get; set; }

    public DateOnly DateCreation {get; set;}

    public required String PathUrl {get;set;}

    public int ClientId { get; set; }

    public Client? Client { get; set; }

    public StatutEnum Statut  {get;set;}
}