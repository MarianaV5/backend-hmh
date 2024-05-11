using Microsoft.EntityFrameworkCore;

namespace TesteProjetoEixo2.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
