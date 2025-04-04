using AplicacaoBlazor.Data;
using AplicacaoBlazor.Interface;
using AplicacaoBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace AplicacaoBlazor.Repositorio
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly BancoContext context;

        public UsuarioRepository(BancoContext _context)
        {
            context = _context;
        }

        public async Task<List<TbUsuario>> ObterTodosUsuairosAsync()
        {
            return await context.TbUsuarios.ToListAsync();
        }

        public async Task AdicionarUsuarioAsync(TbUsuario _usuario)
        {
            context.TbUsuarios.AddAsync(_usuario);
            context.SaveChangesAsync();
        }

        public async Task<TbUsuario> ObterUsuarioIdAsync(int _idUsuario)
        {
            TbUsuario usuario = context.TbUsuarios.FirstOrDefault(x => x.IdUsuario == _idUsuario);

            return usuario;
        }

        public async Task EditarUsuarioAsync(TbUsuario _usuario)
        {
            context.TbUsuarios.Update(_usuario);
            context.SaveChangesAsync();
        }

        public async Task<bool> DeletarUsuarioAsync(int id)
        {
            var usuario = await context.TbUsuarios.FindAsync(id);

            if (usuario != null)
            {
                context.TbUsuarios.Remove(usuario);
                await context.SaveChangesAsync();

                return true;
            }

            return false;
        }
    }
}