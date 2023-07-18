using Clinica.DTOs;
using Clinica.Entities;

namespace Clinica.Interface
{
    public interface IMedicoRepository
    {
        Task <IEnumerable<Medico>> GetMedicosAsync();
        Task<Medico> GetByIdAsync(long id);
        Task<Medico> GetByCRMAsync(int? CRM);
        Task<Medico> AddAsync(Medico medico);
        Task<Medico> UpdateAsync(Medico medico);
        Task<Medico> RemoveAsync(Medico medico);       

    }
}
