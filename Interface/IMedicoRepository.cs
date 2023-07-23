using Clinica.DTOs;
using Clinica.Entities;

namespace Clinica.Interface
{
    public interface IMedicoRepository
    {
        Task <IEnumerable<Medico>> GetMedicosAsync();
        Task<Medico> GetByIdAsync(int id);
        Task<Medico> AddAsync(Medico medico);
        Task<Medico> UpdateAsync(Medico medico);
        Task<Medico> RemoveAsync(Medico medico);       

    }
}
