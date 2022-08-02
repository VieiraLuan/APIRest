using TemplateApplication.ViewModels;

namespace Template.Application.ViewModels
{
    public class UserAuthenticateResponseViewModel
    {
        public UserAuthenticateResponseViewModel(UsuarioViewModel user, string token)
        {
            this.User = user;
            this.Token = token;
        }

        public UsuarioViewModel User { get; set; }
        public string Token { get; set; }
    }
}