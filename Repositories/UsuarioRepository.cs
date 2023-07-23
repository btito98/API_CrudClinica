using Clinica.Context;
using Clinica.Entities;
using Clinica.Interface;
using Microsoft.EntityFrameworkCore;

namespace Clinica.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        AppDbContext _usuarioContext;
        public UsuarioRepository(AppDbContext context) : base(context)
        {
            _usuarioContext = context;  
        }

        public async Task<Usuario> AddAsync(Usuario usuario)
        {
            _usuarioContext.Add(usuario);
            await _usuarioContext.SaveChangesAsync();
            return usuario;
        }

        public async Task<Usuario> GetByIdAsync(int id)
        {
            return await _usuarioContext.Usuario.SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task<IEnumerable<Usuario>> GetUsuariosAsync()
        {
            return await _usuarioContext.Usuario.ToListAsync();
        }

        public async Task<Usuario> RemoveAsync(Usuario usuario)
        {
            _usuarioContext.Remove(usuario);
            await _usuarioContext.SaveChangesAsync();
            return usuario;
        }

        public async Task<Usuario> UpdateAsync(Usuario usuario)
        {
            _usuarioContext.Update(usuario);
            await _usuarioContext.SaveChangesAsync();
            return usuario;
        }
    }
}
