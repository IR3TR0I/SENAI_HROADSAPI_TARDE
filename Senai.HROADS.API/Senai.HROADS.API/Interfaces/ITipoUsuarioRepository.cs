using System;
using System.Collections.Generic;
using System.Linq;
using Senai.HROADS.API.Domains;
using System.Threading.Tasks;

namespace Senai.HROADS.API.Interfaces
{
    interface ITipoUsuarioRepository
    {
        List<TipoUsuarioDomain> Listar();
        TipoUsuarioDomain BuscarPorId();
        void Cadastrar(TipoUsuarioDomain NovoTipoUsuario);
        void Atualizar(int id, TipoUsuarioDomain tipoUsuarioAtualizado);
        void Deletar(int Id);
    }
}
