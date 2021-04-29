using System;
using System.Collections.Generic;
using System.Linq;
using Senai.HROADS.API.Domains;
using System.Threading.Tasks;

namespace Senai.HROADS.API.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuario> Listar();
        Usuario BuscarPorId();
        void Cadastrar(Usuario novoUsuario);
        void Atualizar(int id, Usuario UsuarioAtualizado);
        void Deletar(int Id);
        Usuario BuscarPorEmailSenha(string email, string senha);
        object BuscarPorId(int id);
    }
}
