using Microsoft.EntityFrameworkCore;
using TemplateData.Extensions;
using TemplateData.Mappings;
using TemplateDomain.Entities;

namespace TemplateData.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        #region "dbSets"
        public DbSet<Usuario> usuario { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyDataConfiguration();
            modelBuilder.SeedData(); //Toda vez que rodar uma migration

            base.OnModelCreating(modelBuilder);
        }
    }
}
