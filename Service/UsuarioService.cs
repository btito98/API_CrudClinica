using AutoMapper;
using Clinica.DTOs;
using Clinica.Entities;
using Clinica.Interface;

namespace Clinica.Service
{
    public class UsuarioService : IUsuarioService
    {
        IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;

        public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        public async Task Add(UsuarioDTO usuarioDTO)
        {
            var usuarioEntity = _mapper.Map<Usuario>(usuarioDTO);
            await _usuarioRepository.AddAsync(usuarioEntity);
        }

        public async Task<UsuarioDTO> GetById(int id)
        {
           var usuarioEntity = _usuarioRepository.GetByIdAsync(id);
            return _mapper.Map<UsuarioDTO>(usuarioEntity);
        }

        public async Task<IEnumerable<UsuarioDTO>> GetUsuarios()
        {
            var usuarioEntity = await _usuarioRepository.GetUsuariosAsync();
            return _mapper.Map<IEnumerable<UsuarioDTO>>(usuarioEntity);
        }

        public async Task Remove(int id)
        {
            var usuarioEntity = _usuarioRepository.GetByIdAsync(id).Result;
            await _usuarioRepository.RemoveAsync(usuarioEntity);
        }

        public async Task Update(UsuarioDTO usuarioDTO)
        {
            var usuarioEntity = _mapper.Map<Usuario>(usuarioDTO);
            await _usuarioRepository.UpdateAsync(usuarioEntity);
        }
    }
}
