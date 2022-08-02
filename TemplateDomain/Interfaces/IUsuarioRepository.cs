using TemplateDomain.Entities;

namespace TemplateDomain.Interfaces
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
         IEnumerable<Usuario> GetAll();



    }
}
