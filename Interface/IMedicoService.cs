using Clinica.DTOs;
using Clinica.Entities;

namespace Clinica.Interface
{
    public interface IMedicoService
    {
        Task<IEnumerable<MedicoDTO>> GetMedicos();
        Task<MedicoDTO> GetById(int id);
        Task Add(MedicoDTO medicoDTO);
        Task Update(MedicoDTO medicoDTO);
        Task Remove(int id);
    }
}
