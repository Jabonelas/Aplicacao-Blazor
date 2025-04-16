using AplicacaoBlazor.Models;

namespace AplicacaoBlazor.Interface
{
    public interface ITarefaRepository
    {
        Task AdicionarTarefaAsync(TbTarefa _tarefa);

        Task<bool> IsEmailExisteAsync(string _email);

        Task<List<TbTarefa>> ObterTodosTarefasAsync();

        Task<List<TbTarefa>> ObterTarefaEmailAsync(string _email);

        Task EditarTarefaAsync(TbTarefa _tarefa);

        Task<bool> DeletarTarefaAsync(int _id);

        Task<int> ObterIdUsuario(string _email);
    }
}