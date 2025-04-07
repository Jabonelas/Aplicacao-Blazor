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
            try
            {
                context.TbUsuarios.AddAsync(_usuario);
                context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("Erro desconhecido ao adicionar usuário.", ex);
            }
        }

        public async Task<bool> IsEmailExisteAsync(string _email)
        {
            try
            {
                bool isEmailExiste = await context.TbUsuarios.AnyAsync(x => x.UsEmail == _email);

                return isEmailExiste;
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Erro desconhecido ao buscar email do usuário.", ex);
            }
        }

        public async Task<TbUsuario> ObterUsuarioIdAsync(int _idUsuario)
        {
            try
            {
                TbUsuario usuario = context.TbUsuarios.FirstOrDefault(x => x.IdUsuario == _idUsuario);

                return usuario;
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Erro desconhecido ao buscar usuário por ID.", ex);
            }
        }

        public async Task EditarUsuarioAsync(TbUsuario _usuario)
        {
            try
            {
                context.TbUsuarios.Update(_usuario);
                context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("Falha ao atualizar os dados do usuário no banco de dados.", ex);
            }
        }

        public async Task<bool> DeletarUsuarioAsync(int id)
        {
            try
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
            catch (DbUpdateException ex)
            {
                throw new Exception("Falha ao deletar usuário no banco de dados.", ex);
            }
        }
    }
}