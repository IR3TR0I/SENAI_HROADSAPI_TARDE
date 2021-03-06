using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.HROADS.API.Interfaces;
using Senai.HROADS.API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.HROADS.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class HabilidadesController : ControllerBase
    {
        private IHabilidadeRepository _habilidadeRepository { get; set; }

        public HabilidadesController()
        {
            _habilidadeRepository = new HabilidadeRepository();
        }

        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_habilidadeRepository.Listar());
        }

        [Authorize]
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_habilidadeRepository.BuscarPorId(id));
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(HabilidadesController novoHabilidade)
        {
            try
            {
                _habilidadeRepository.Cadastrar(novoHabilidade);

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
                _habilidadeRepository.Deletar(id);
                return StatusCode(200);
            }
            catch (Exception codErro)
            {
                return BadRequest(codErro);

            }
        }

        [Authorize(Roles = "1")]
        [HttpPut("{id}")]
        public IActionResult Update(int id, HabilidadesController habilidadeAtualizado)
        {
            _habilidadeRepository.Atualizar(id, habilidadeAtualizado);

            return StatusCode(200);
        }
    }
}
