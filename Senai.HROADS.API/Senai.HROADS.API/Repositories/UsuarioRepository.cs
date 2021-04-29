using Senai.HROADS.API.Domains;
using Senai.HROADS.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.HROADS.API.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public void Atualizar(int id, Usuario UsuarioAtualizado)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarPorEmailSenha(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarPorId()
        {
            throw new NotImplementedException();
        }

        public object BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
