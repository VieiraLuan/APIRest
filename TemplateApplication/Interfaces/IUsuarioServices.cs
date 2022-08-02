using Template.Application.ViewModels;
using TemplateApplication.ViewModels;

namespace TemplateApplication.Interfaces
{
    public interface IUsuarioServices
    {
        List<UsuarioViewModel> Get();

        bool Post(UsuarioViewModel usuarioViewModel);

        public UsuarioViewModel GetById(string id);

        bool Put(UsuarioViewModel usuarioViewModel);

        bool Delete(string id);

        UserAuthenticateResponseViewModel Authenticate(UserAuthenticateRequestViewModel user);


    }
}
