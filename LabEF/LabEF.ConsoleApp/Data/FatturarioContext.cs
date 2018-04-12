using LabEF.ConsoleApp.Models;
using System.Data.Entity;

namespace LabEF.ConsoleApp.Data
{
    class FatturarioContext : DbContext
    {
        public DbSet<Fattura> Fatture { get; set; }
        public DbSet<VoceFattura> VociFatture { get; set; }

        public FatturarioContext(): base("FatturiarioDbConnection")
        {
        }
    }
}
