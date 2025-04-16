using AplicacaoBlazor.DTO.Tarefa;
using AplicacaoBlazor.Interface;
using AplicacaoBlazor.Models;

namespace AplicacaoBlazor.Service
{
    public class TarefaService : ITarefaService
    {
        private readonly ITarefaRepository tarefaRepository;

        public TarefaService(ITarefaRepository _tarefaRepository)
        {
            tarefaRepository = _tarefaRepository;
        }

        public async Task<bool> CadastrarTarefa(TarefaDTO _tarefa)
        {
            return false;
        }

        public async Task<bool> IsEmailExiste(string _email)
        {
            return false;
        }

        public Task<List<TbTarefa>> ListaTarefa()
        {
            return null;
        }

        public Task<TbTarefa> BuscarUsuarioEmail(string _email)
        {
            return null;
        }

        public async Task<bool> EditarTarefa(TbTarefa _tarefa)
        {
            return false;
        }

        public async Task<bool> DeletarTarefa(int _id)
        {
            return false;
        }
    }
}