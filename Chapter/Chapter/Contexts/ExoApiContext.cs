using Chapter.Domains;
using Microsoft.EntityFrameworkCore;

namespace Chapter.Contexts {
    public class ExoApiContext : DbContext {
        public ExoApiContext() {}
        public ExoApiContext(DbContextOptions<ExoApiContext> options) : base(options) {}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer("Data Source = ; Initial catalog = ExoApi; Integrated Security = true; TrustServerCertificate = true");
            }
        }
        public DbSet<Projeto> Projetos { get; set; }
    }
}