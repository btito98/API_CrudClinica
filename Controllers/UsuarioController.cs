using Clinica.DTOs;
using Clinica.Entities;
using Clinica.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clinica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        // GET: api/<UsuarioController>
        [HttpGet("BuscarTodosUsuarios/")]
        public async Task<ActionResult<IEnumerable<UsuarioDTO>>> Get()
        {
            try
            {
                var usuarios = await _usuarioService.GetUsuarios();
                return Ok(usuarios);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsuarioController>
        [HttpPost("Criar/")]
        public async Task<ActionResult> Post([FromBody] UsuarioDTO usuarioDTO)
        {
            try
            {
                await _usuarioService.Add(usuarioDTO);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("Deletar/{id}")]
        public async Task<ActionResult<UsuarioDTO>> Delete(long id)
        {
            try
            {
                var usuario = _usuarioService.GetById(id);
                await _usuarioService.Remove(id);
                return Ok();
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
