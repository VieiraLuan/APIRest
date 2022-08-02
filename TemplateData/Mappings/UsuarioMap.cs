using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TemplateDomain.Entities;

namespace TemplateData.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {

        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Id).HasMaxLength(100).IsRequired();
        }
    }
}
