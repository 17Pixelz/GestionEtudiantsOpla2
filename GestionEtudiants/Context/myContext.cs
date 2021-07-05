using Microsoft.EntityFrameworkCore;
using GestionEtudiants.Models;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace GestionEtudiants.Context
{
    public class myContext : DbContext
    {
        private readonly DbContextOptions _options;


        public myContext() : base()
        {
        }

        public myContext(DbContextOptions options) : base(options)
        {
            _options = options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            SchoolDBInitializer oodb = new SchoolDBInitializer();


            modelBuilder.Entity<Departement>().HasData(oodb.departements);
            modelBuilder.Entity<Document>().HasData(oodb.documents);
            modelBuilder.Entity<Etudiant>().HasData(oodb.etudiants);
            modelBuilder.Entity<Filiere>().HasData(oodb.filieres);
            modelBuilder.Entity<Classe>().HasData(oodb.classes);
            modelBuilder.Entity<Module>().HasData(oodb.modules);
            modelBuilder.Entity<Note>().HasData(oodb.notes);
            modelBuilder.Entity<Professeur>().HasData(oodb.professeurs);
            modelBuilder.Entity<Etat>().HasData(oodb.etats);

            modelBuilder.Entity<Module>().HasOne(m => m.professeur).WithMany(p => p.modules).OnDelete(DeleteBehavior.NoAction);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("myconn");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }


        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<Classe> classes { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Filiere> Filieres { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Professeur> Professeurs { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Departement> departements{ get; set; }

    }
}
