using Microsoft.EntityFrameworkCore;
namespace UniversityPlatformApi.Data.Models
{
    public class UniversityPlatformDBContext : DbContext
    {
        public UniversityPlatformDBContext(DbContextOptions<UniversityPlatformDBContext> options) : base(options)
        {

        }

        public DbSet<University> Universities { get; set; }
        public DbSet<School> Schools { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<University>().HasData(
                new University { UniversityId = 1, Name = "Universidad Nacional Del Nordeste" },
                new University { UniversityId = 2, Name = "Universidad de la Defensa Nacional" },
                new University { UniversityId = 3, Name = "Universidad Austral" },
                new University { UniversityId = 4, Name = "Universidad Nacional del Arte (UNA)" }
            );

            modelBuilder.Entity<School>().HasData(
                new School { SchoolId = 1, Name = "Arquitectura y Urbanismo", Address = "Av. Las Heras 727 - CP 3500 Resistencia, Chaco", UniversityId = 1},
                new School { SchoolId = 2, Name = "Artes, Diseño y Ciencias de la Cultura", Address = "A. Illia 368. - CP 3500 Resistencia, Chaco.", UniversityId = 1},
                new School { SchoolId = 3, Name = "Ciencias Agrarias", Address = "Sargento Cabral 2131– CP 3400 Corrientes", UniversityId = 1},
                new School { SchoolId = 4, Name = "Ciencias Económicas", Address = "Av. Las Heras 727 - CP 3500 Resistencia, Chaco", UniversityId = 1}
                );

            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Name = "Lisandro", Address = "Rivadavia", UniversityId = 1 }    
            );
        }

    }
}
