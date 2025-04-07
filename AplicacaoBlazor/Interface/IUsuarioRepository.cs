using AplicacaoBlazor.Models;

namespace AplicacaoBlazor.Interface
{
    public interface IUsuarioRepository
    {
        Task AdicionarUsuarioAsync(TbUsuario _usuario);

        Task<bool> IsEmailExisteAsync(string _email);

        Task<List<TbUsuario>> ObterTodosUsuairosAsync();

        Task<TbUsuario> ObterUsuarioIdAsync(int _id);

        Task EditarUsuarioAsync(TbUsuario _usuario);

        Task<bool> DeletarUsuarioAsync(int _id);
    }
}