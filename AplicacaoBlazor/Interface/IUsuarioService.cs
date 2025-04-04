using System.ComponentModel;
using AplicacaoBlazor.DTO;
using AplicacaoBlazor.Models;
using AplicacaoBlazor.Pages.Usuario;

namespace AplicacaoBlazor.Interface
{
    public interface IUsuarioService
    {
        public Task CadastrarUsuario(UsuarioDTO _usuario);

        public Task<List<TbUsuario>> ListaUsuarios();

        public Task<TbUsuario> BuscarUsuarioId(int _id);

        public Task EditarUsuario(TbUsuario _usuario);

        public Task<bool> DeletarUsuario(int _id);
    }
}