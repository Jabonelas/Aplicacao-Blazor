using AplicacaoBlazor.Data;
using AplicacaoBlazor.Interface;
using AplicacaoBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace AplicacaoBlazor.Repositorio
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly BancoContext context;

        public TarefaRepository(BancoContext _context)
        {
            context = _context;
        }

        public async Task AdicionarTarefaAsync(TbTarefa _tarefa)
        {
            context.TbTarefas.AddAsync(_tarefa);
            context.SaveChangesAsync();
        }

        public async Task<bool> IsEmailExisteAsync(string _email)
        {
            bool isEmailExiste = await context.TbUsuarios.AnyAsync(x => x.UsEmail == _email);

            return isEmailExiste;
        }

        public async Task<List<TbTarefa>> ObterTodosTarefasAsync()
        {
            List<TbTarefa> listaTarefa = await context.TbTarefas.ToListAsync();

            return listaTarefa;
        }

        public async Task<List<TbTarefa>> ObterTarefaEmailAsync(string _email)
        {
            int idUsuario = await ObterIdUsuario(_email);

            List<TbTarefa> listaTarefa = await context.TbTarefas.Where(x => x.FkUsuario == idUsuario).ToListAsync();

            return listaTarefa;
        }

        public async Task<int> ObterIdUsuario(string _email)
        {
            TbUsuario usuario = await context.TbUsuarios.FirstOrDefaultAsync(x => x.UsEmail == _email);

            return usuario.IdUsuario;
        }

        public async Task EditarTarefaAsync(TbTarefa _tarefa)
        {
            context.TbTarefas.Update(_tarefa);
            await context.SaveChangesAsync();
        }

        public async Task<TbTarefa> ObterIdTarefa(int _id)
        {
            TbTarefa tarefa = await context.TbTarefas.FirstOrDefaultAsync(x => x.IdTarefa == _id);

            return tarefa;
        }

        public async Task<bool> DeletarTarefaAsync(int _id)
        {
            try
            {
                TbTarefa tarfa = await ObterIdTarefa(_id);

                if (tarfa != null)
                {
                    context.TbTarefas.Remove(tarfa);
                    context.SaveChangesAsync();

                    return true;
                }

                return false;
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("Falha ao deletar tarefa no banco de dados.", ex);
            }
        }
    }
}