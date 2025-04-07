using System.ComponentModel;
using AplicacaoBlazor.DTO;
using AplicacaoBlazor.Models;
using AplicacaoBlazor.Pages.Usuario;

namespace AplicacaoBlazor.Interface
{
    public interface IUsuarioService
    {
        public Task<bool> CadastrarUsuario(UsuarioDTO _usuario);

        public Task<bool> IsEmailExiste(string _email);

        public Task<List<TbUsuario>> ListaUsuarios();

        public Task<TbUsuario> BuscarUsuarioId(int _id);

        public Task<bool> EditarUsuario(TbUsuario _usuario);

        public Task<bool> DeletarUsuario(int _id);
    }
}