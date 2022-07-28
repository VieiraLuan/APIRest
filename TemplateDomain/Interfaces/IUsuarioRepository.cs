using TemplateDomain.Entities;

namespace TemplateDomain.Interfaces
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        public IEnumerable<Usuario> GetAll();



    }
}
