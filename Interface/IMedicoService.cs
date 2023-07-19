using Clinica.DTOs;
using Clinica.Entities;

namespace Clinica.Interface
{
    public interface IMedicoService
    {
        Task<IEnumerable<MedicoDTO>> GetMedicos();
        Task<MedicoDTO> GetById(long id);
        Task<MedicoDTO> GetByCRM(int? CRM);
        Task Add(MedicoDTO medicoDTO);
        Task Update(MedicoDTO medicoDTO);
        Task Remove(long id);
    }
}
