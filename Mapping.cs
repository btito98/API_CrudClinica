using AutoMapper;
using Clinica.DTOs;
using Clinica.Entities;

namespace Clinica
{
    public class Mapping : Profile
    {
        public Mapping()
        { 
            CreateMap<Medico, MedicoDTO>().ReverseMap();
            CreateMap<Usuario, UsuarioDTO>().ReverseMap();
        }
    }
}
