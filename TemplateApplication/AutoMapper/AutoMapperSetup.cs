using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
