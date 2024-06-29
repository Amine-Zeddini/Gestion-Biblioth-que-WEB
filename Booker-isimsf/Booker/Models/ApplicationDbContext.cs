using System.Data.Entity;

namespace Booker.Models
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Etudiant> Etudiants { get; set; }

        public DbSet<Livre> Livres { get; set; }

        public DbSet<EtudiantLivres> EtudiantLivres { get; set; }
    }
}