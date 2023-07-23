using AutoMapper;
using Clinica.DTOs;
using Clinica.Entities;
using Clinica.Interface;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Clinica.Service
{
    public class MedicoService : IMedicoService
    {
        private IMedicoRepository _medicoRepository;
        private readonly IMapper _mapper;

        public MedicoService(IMedicoRepository medicoRepository, IMapper mapper)
        {
            _medicoRepository = medicoRepository;
            _mapper = mapper;
        }

        public async Task Add(MedicoDTO medicoDTO)
        {
            var medicoEntity = _mapper.Map<Medico>(medicoDTO);
            await _medicoRepository.AddAsync(medicoEntity);

        }
        public async Task<MedicoDTO> GetById(int id)
        {
            var medicoEntity = _medicoRepository.GetByIdAsync(id).Result;
            return _mapper.Map<MedicoDTO>(medicoEntity);
        }

        public async Task<IEnumerable<MedicoDTO>> GetMedicos()
        {
            var medicoEntity = await _medicoRepository.GetMedicosAsync();
            return _mapper.Map<IEnumerable<MedicoDTO>>(medicoEntity);   
        }

        public async Task Remove(int id)
        {
            var medicoEntity = _medicoRepository.GetByIdAsync(id).Result;
            await _medicoRepository.RemoveAsync(medicoEntity);
        }

        public async Task Update(MedicoDTO medicoDTO)
        {
            var medicoEntity = _mapper.Map<Medico>(medicoDTO);
            await _medicoRepository.UpdateAsync(medicoEntity);
        }

    }
}
