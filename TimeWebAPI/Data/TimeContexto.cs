using Microsoft.EntityFrameworkCore;
using TimeWebAPI.Model;

namespace TimeWebAPI.Data
{
    public class TimeContexto : DbContext 
    {
        public DbSet<Jogador> Jogadors { get; set;}

        public DbSet<Posição> Posiçãos { get; set;}

        public DbSet<Time> Times { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=BB8\\SQLEXPRESS;Initial Catalog=TimeDeVolei;Integrated Security=True;Encrypt=False");
        }
    }
}
