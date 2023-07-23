using Clinica.DTOs;
using Clinica.Entities;
using Clinica.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clinica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        private readonly IMedicoService _mediicoService;

        public MedicoController(IMedicoService medicoService)
        {
            _mediicoService = medicoService;
        }

        [HttpGet("BuscarTodosMedicos/")]
        public async Task<ActionResult<IEnumerable<MedicoDTO>>> Get()
        {
            var medicos = await _mediicoService.GetMedicos();
            return Ok(medicos);
        }


        [HttpGet("BuscarPorId/{id}")]
        public async Task<ActionResult<MedicoDTO>> Get(int id)
        {
            var medico = await _mediicoService.GetById(id);
            return Ok(medico);
        }


        [HttpPost("Criar/")]
        public async Task<ActionResult> Post([FromBody] MedicoDTO medicoDTO)
        {
            try
            {
                await _mediicoService.Add(medicoDTO);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpPut("Atualizar/{id}")]
        public async Task<ActionResult<Medico>> Put(int id, [FromBody] MedicoDTO medicoDTO)
        {
            try
            {

                await _mediicoService.Update(medicoDTO);
                return Ok(medicoDTO);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        [HttpDelete("Deletar/{id}")]
            public async Task<ActionResult<MedicoDTO>> Delete(int id)
            {
                try
                {
                    await _mediicoService.Remove(id);
                    return Ok();
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }

            }
        }
    }
