using TemplateData.Context;
using TemplateDomain.Entities;
using TemplateDomain.Interfaces;

namespace TemplateData.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(DataContext context) : base(context)
        {
        }

        public IEnumerable<Usuario> GetAll()
        {
            return Query(x => !x.IsDeleted);
        }
    }
}
