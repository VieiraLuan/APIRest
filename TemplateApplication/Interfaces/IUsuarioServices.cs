using TemplateApplication.ViewModels;

namespace TemplateApplication.Interfaces
{
    public interface IUsuarioServices
    {
        List<UsuarioViewModel> Get();

        bool Post(UsuarioViewModel usuarioViewModel);

        public UsuarioViewModel GetById(string id);

        public bool Put(UsuarioViewModel usuarioViewModel);

        public bool Delete(string id);


    }
}
