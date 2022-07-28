using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TemplateDomain.Entities;
using TemplateDomain.Models;

namespace TemplateData.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            //Toda vez que add uma migration
            builder.Entity<Usuario>().HasData(new Usuario
            {
                Id = Guid.Parse("21bf7346-e5ec-4291-bb7b-ea4ba66506bb"),
                Nome = "Usuario Padrão",
                Email = "Usuariopadra@projeto.com",
                DateCreated = new DateTime(2020, 2, 3),
                IsDeleted = false,
                DateUpdated = null
            });

            return builder;
        }

        public static ModelBuilder ApplyDataConfiguration(this ModelBuilder builder)
        {
            foreach (IMutableEntityType entityType in builder.Model.GetEntityTypes())
            {
                foreach (IMutableProperty prop in entityType.GetProperties())
                {
                    switch (prop.Name)
                    {
                        case nameof(Entity.Id):
                            prop.IsKey();
                            break;
                        case nameof(Entity.DateUpdated):
                            prop.IsNullable = true;
                            break;
                        case nameof(Entity.DateCreated):
                            prop.IsNullable = false;
                            prop.SetDefaultValue(DateTime.Now);
                            break;
                        case nameof(Entity.IsDeleted):
                            prop.IsNullable = false;
                            prop.SetDefaultValue(false);
                            break;

                        default:
                            break;
                    }

                }
            }

            return builder;
        }




    }
}
