using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
  
    public class equiposContext:DbContext
    {
        public equiposContext(DbContextOptions<equiposContext> options):base(options) 
        { 

        }

        public DbSet<Equipos> Equipos { get; set; }
        

    }
}
