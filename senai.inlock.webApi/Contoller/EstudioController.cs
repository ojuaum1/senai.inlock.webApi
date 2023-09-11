using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interface;
using senai.inlock.webApi.Repositories;

namespace senai.inlock.webApi.Contoller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudioController : ControllerBase
    {
        private IEstudio _Estudio { get; set; }

        public EstudioController()
        {
            _Estudio = new EstudioRepository();
        }


        [HttpGet]
        public IActionResult ListarEstudio()
        {
            try
            {
                List<JogoDomain> listaJogos = _Estudio.ListarEstudio();
                return Ok(listaJogos);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

        [HttpPost]
        public IActionResult Cadastrar(EstudioDomain NovoEstudio)
        {
            try
            {
                _Estudio.Cadastrar(NovoEstudio);
                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }
    }
}

