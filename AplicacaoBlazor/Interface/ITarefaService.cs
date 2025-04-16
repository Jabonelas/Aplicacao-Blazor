using AplicacaoBlazor.DTO.Tarefa;
using AplicacaoBlazor.DTO.Usuario;
using AplicacaoBlazor.Models;

namespace AplicacaoBlazor.Interface
{
    public interface ITarefaService
    {
        public Task<bool> CadastrarTarefa(TarefaDTO _tarefa);

        public Task<bool> IsEmailExiste(string _email);

        public Task<List<TbTarefa>> ListaTarefa();

        public Task<TbTarefa> BuscarUsuarioEmail(string _email);

        public Task<bool> EditarTarefa(TbTarefa _tarefa);

        public Task<bool> DeletarTarefa(int _id);
    }
}