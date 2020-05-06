using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityPlatformApi.Models
{
    public class UniversityPlatformDBContext : DbContext
    {
        public UniversityPlatformDBContext(DbContextOptions<UniversityPlatformDBContext> options) : base(options) 
        {
            
        }

        public DbSet<University> Universities { get; set; }
        public DbSet<School> Schools { get; set; }

    }
}
