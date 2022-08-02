using Microsoft.AspNetCore.Mvc;
using Template.Application.ViewModels;
using TemplateApplication.Interfaces;
using TemplateApplication.ViewModels;

namespace APIRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {


        private readonly IUsuarioServices usuarioServices;

        public UsuarioController(IUsuarioServices usuarioServices)
        {
            this.usuarioServices = usuarioServices;
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(this.usuarioServices.Get());

        }

        [HttpPost]
        public IActionResult Post(UsuarioViewModel usuarioViewModel)
        {
            return Ok(this.usuarioServices.Post(usuarioViewModel));
        }


        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            return Ok(usuarioServices.GetById(id));
        }

        [HttpPut]
        public IActionResult Put(UsuarioViewModel usuarioViewModel)
        {
            return Ok(usuarioServices.Put(usuarioViewModel));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            return Ok(usuarioServices.Delete(id));
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(UserAuthenticateRequestViewModel userViewModel)
        {
            return Ok(this.usuarioServices.Authenticate(userViewModel));
        }



    }
}
