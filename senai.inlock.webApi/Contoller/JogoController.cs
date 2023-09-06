using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using senai.inlock.webApi.Repositories;

namespace senai.inlock.webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class JogosController : ControllerBase
    {
        private IJogo _jogo { get; set; }

        public JogosController()
        {
            _jogo = new JogosRepository();
        }


        [HttpGet]
        public IActionResult ListarJogos()
        {
            try
            {
                List<JogoDomain> listaJogos = _jogo.Listar();
                return Ok(listaJogos);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

        [HttpPost]
        public IActionResult Cadastrar(JogoDomain jogosCadastrado)
        {
            try
            {
                _jogo.Cadastrar(jogosCadastrado);
                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }
    }
}