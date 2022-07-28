using AutoMapper;
using TemplateApplication.ViewModels;
using TemplateDomain.Entities;

namespace TemplateApplication.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            #region ViewModeltoDomain
            CreateMap<UsuarioViewModel, Usuario>();
            #endregion

            #region DomainToViewModel
            CreateMap<Usuario, UsuarioViewModel>();
            #endregion

        }

    }
}
