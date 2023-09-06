using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interface;
using senai.inlock.webApi.Interfaces;
using senai.inlock.webApi.Repositories;
using static senai.inlock.webApi.Interface.IUsuario;

namespace senai.inlock.webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UsuariosController : ControllerBase
    {
        private IUsuario _usuario;
       

        public UsuariosController()
        {
            _usuario = new UsuariosRepository();
        }

        [HttpPost]
        public IActionResult Login(UsuarioDomain usuario)
        {
            try
            {
                UsuarioDomain usuarioBusca = _usuario.Login(usuario.Email, usuario.Senha);

                if (usuarioBusca != null)
                {
                    return Ok(usuarioBusca);
                }
                return BadRequest("Usuario não encontrado!");
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }
    }
}