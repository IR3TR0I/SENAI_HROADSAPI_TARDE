using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.HROADS.API.Domains;
using Senai.HROADS.API.Interfaces;
using Senai.HROADS.API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.HROADS.API.Controllers
{
    //http://localgost:500/api/generos
    [Produces("applicationJson")]
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesController : ControllerBase
    {
        private IClasseRepository classeRepository { get; set; }

        public ClassesController()
        {
            classeRepository = new ClasseRepository();
        }

        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            List<ClasseDomain> listaGeneros = classeRepository.Listar();

            return Ok(classeRepository.Listar());
        }

        [Authorize]
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(classeRepository.BuscarPorId(id));
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(ClasseDomain novaClasse)
        {
            try
            {
               classeRepository.Cadastrar(novaClasse);

                return NoContent();
            }
            catch (Exception codErro)
            {
                return BadRequest(codErro);

            }
        }

        [Authorize(Roles = "1")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                classeRepository.Deletar(id);
                return StatusCode(200);
            }
            catch (Exception codErro)
            {
                return BadRequest(codErro);

            }
        }

        [Authorize(Roles = "1")]
        [HttpPut("{id}")]
        public IActionResult Update(int id, ClasseDomain classeAtualizado)
        {
            classeRepository.atualizar(id, classeAtualizado);

            return StatusCode(200);
        }
    }
}
