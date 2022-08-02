
using AutoMapper;
using Template.Application.ViewModels;
using Template.Auth.Services;
using TemplateApplication.Interfaces;
using TemplateApplication.ViewModels;
using TemplateDomain.Entities;
using TemplateDomain.Interfaces;

namespace TemplateApplication.Services
{
    public class UsuarioServices : IUsuarioServices
    {
        private readonly IUsuarioRepository usuarioRepository;
        private readonly IMapper mapper;


        public UsuarioServices(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            this.usuarioRepository = usuarioRepository;
            this.mapper = mapper;
        }

        public List<UsuarioViewModel> Get()
        {
            List<UsuarioViewModel> list = new List<UsuarioViewModel>();

            IEnumerable<Usuario> _usuarios = usuarioRepository.GetAll();

            list = mapper.Map<List<UsuarioViewModel>>(_usuarios);

            return list;
        }

        public bool Post(UsuarioViewModel usuarioViewModel)
        {
            /*tem que ter os mesmos nomes de propriedades para fazer direto, se nao terá que atribuilas*/
            Usuario usuario = mapper.Map<Usuario>(usuarioViewModel);

            this.usuarioRepository.Create(usuario);

            return true;
        }

        public UsuarioViewModel GetById(string id)
        {
            if (!Guid.TryParse(id, out Guid result))
                throw new Exception("resultado não é valido");

            Usuario _usuario = usuarioRepository.Find(x => x.Id == result && !x.IsDeleted);


            if (_usuario == null)
                throw new Exception("Usuario não encontrado");


            return mapper.Map<UsuarioViewModel>(_usuario);
        }

        public bool Put(UsuarioViewModel usuarioViewModel)
        {
            Usuario _usuario = usuarioRepository.Find(x => x.Id == usuarioViewModel.Id && !x.IsDeleted);
            if (_usuario == null)
                throw new Exception("Usuario não encontrado");


            _usuario = mapper.Map<Usuario>(usuarioViewModel);

            usuarioRepository.Update(_usuario);

            return true;

        }

        public bool Delete(string id)
        {
            if (!Guid.TryParse(id, out Guid result))
                throw new Exception("resultado não é valido");

            Usuario _usuario = usuarioRepository.Find(x => x.Id == result && !x.IsDeleted);


            if (_usuario == null)
                throw new Exception("Usuario não encontrado");

            return usuarioRepository.Delete(_usuario);
        }

        public UserAuthenticateResponseViewModel Authenticate(UserAuthenticateRequestViewModel user)
        {
            Usuario usuario = this.usuarioRepository.Find(x => !x.IsDeleted && x.Email.ToLower() == user.Email.ToLower());


            if (usuario == null)
                throw new Exception("Usuario não encontrado");

            return new  UserAuthenticateResponseViewModel(mapper.Map<UsuarioViewModel>(usuario), TokenService.GenerateToken(usuario));

        }
    }
}
