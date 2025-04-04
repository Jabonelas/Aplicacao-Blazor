using System.ComponentModel;
using AplicacaoBlazor.DTO;
using AplicacaoBlazor.Interface;
using AplicacaoBlazor.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AplicacaoBlazor.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository usuarioRepository;

        public UsuarioService(IUsuarioRepository _usuarioRepository)
        {
            usuarioRepository = _usuarioRepository;
        }

        public async Task CadastrarUsuario(UsuarioDTO _usuario)
        {
            TbUsuario usuario = new TbUsuario();

            usuario.UsNome = _usuario.nome;
            usuario.UsEmail = _usuario.email;
            usuario.UsSenha = _usuario.senha;

            await usuarioRepository.AdicionarUsuarioAsync(usuario);
        }

        public async Task<List<TbUsuario>> ListaUsuarios()
        {
            List<TbUsuario> listaUsuarios = await usuarioRepository.ObterTodosUsuairosAsync();

            return listaUsuarios;
        }

        public async Task<bool> DeletarUsuario(int _id)
        {
            bool isUsuarioDeletado = await usuarioRepository.DeletarUsuarioAsync(_id);

            return isUsuarioDeletado;
        }

        public async Task<TbUsuario> BuscarUsuarioId(int _id)
        {
            TbUsuario usuario = await usuarioRepository.ObterUsuarioIdAsync(_id);

            return usuario;
        }

        public async Task EditarUsuario(TbUsuario _usuario)
        {
            await usuarioRepository.EditarUsuarioAsync(_usuario);
        }
    }
}