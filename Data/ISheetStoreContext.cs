using ISheet.Entities;
using Microsoft.EntityFrameworkCore;

namespace ISheet.Data;

class ISheetStoreContext(DbContextOptions<ISheetStoreContext> options) : DbContext(options)
{
    public DbSet<FicheIntervention> FicheInterventions => Set<FicheIntervention>();

    public DbSet<Client> Clients => Set<Client>();

}