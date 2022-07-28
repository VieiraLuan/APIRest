﻿using Microsoft.AspNetCore.Mvc;
using TemplateApplication.Interfaces;
using TemplateApplication.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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




        /*-------------------------------------------------------------------------*/
        /*

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        */
    }
}
