using Clinica.Context;
using Clinica.DTOs;
using Clinica.Entities;
using Clinica.Interface;
using Microsoft.EntityFrameworkCore;

namespace Clinica.Repositories
{
    public class MedicoRepository : Repository<Medico>, IMedicoRepository
    {
        private AppDbContext _medicoContext;
        public MedicoRepository(AppDbContext context) : base(context)
        {
            _medicoContext = context;
        }

        public async Task<Medico> AddAsync(Medico medico)
        {
            _medicoContext.Add(medico);
            await _medicoContext.SaveChangesAsync();
            return medico;
        }

        public async Task<Medico> GetByIdAsync(int id)
        {
            return await _medicoContext.Medico.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IEnumerable<Medico>> GetMedicosAsync()
        {
            return await _medicoContext.Medico.ToListAsync();
        }

        public async Task<Medico> RemoveAsync(Medico medico)
        {
          _medicoContext.Medico.Remove(medico);
            await _medicoContext.SaveChangesAsync();
            return medico;

        }

        public async Task<Medico> UpdateAsync(Medico medico)
        {
            _medicoContext.Update(medico);
            await _medicoContext.SaveChangesAsync();
            return medico;
        }

     
    }
}
