using Clinica.DTOs;
using Clinica.Entities;
using Clinica.Interface;
using Microsoft.AspNetCore.Mvc;


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

        
        [HttpGet("BuscarPorId/{id}")]
        public async Task<ActionResult<UsuarioDTO>> Get(int id)
        {
            try
            {
                var usuario = await _usuarioService.GetById(id);
                return Ok();
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

       
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

        
        [HttpPut("Atualizar/{id}")]
        public async Task<ActionResult<UsuarioDTO>>Put(int id, [FromBody] UsuarioDTO usuarioDTO)
        {
            try
            {
                await _usuarioService.Update(usuarioDTO);
                return Ok(usuarioDTO);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

       
        [HttpDelete("Deletar/{id}")]
        public async Task<ActionResult<UsuarioDTO>> Delete(int id)
        {
            try
            {
                await _usuarioService.Remove(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
