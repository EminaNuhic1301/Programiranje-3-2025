using Microsoft.EntityFrameworkCore;

using Studentska.Data.Entiteti;
using Studentska.Data.Modeli.IB240167;
using System.Configuration;

namespace Studentska.Servis
{
    public class StudentskaDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            optionsBuilder.UseSqlite(ConfigurationManager.ConnectionStrings["StudentskaDb"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UniverzitetiBrojIndeksa>().HasKey(x => x.UniverzitetBrojIndeksaID);
            modelBuilder.Entity<RazmjeneBrojIndeksa>().HasKey(x => x.RazmjeneBrojIndeksaID);
        }

        public DbSet<Drzava> Drzave { get; set; }
        public DbSet<Grad> Gradovi { get; set; }
        public DbSet<Spol> Spolovi { get; set; }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<AkademskaGodina> AkademskeGodine { get; set; }
        public DbSet<UniverzitetiBrojIndeksa> UniverzitetiBrojIndeksa { get; set; }
        public DbSet<RazmjeneBrojIndeksa> RazmjeneBrojIndeksa { get; set; }
    }
}
