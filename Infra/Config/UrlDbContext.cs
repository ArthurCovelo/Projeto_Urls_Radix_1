using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Config
{
    public class UrlDbContext : DbContext
    {
        public UrlDbContext(DbContextOptions<UrlDbContext> options) : base(options)
        {
        }
        public DbSet<Url> Urls { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            try
            {
                base.OnModelCreating(modelBuilder);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao definir o modelo do banco de dados.", ex);
            }
        }
    }
}

