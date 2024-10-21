using Microsoft.EntityFrameworkCore;

namespace Projeto_Ads.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<InstituicaodeEnsino> InstituicaodeEnsino {  get; set; }
        
        }
 }
