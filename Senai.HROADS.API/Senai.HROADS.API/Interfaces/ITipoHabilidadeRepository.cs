using System;
using System.Collections.Generic;
using System.Linq;
using Senai.HROADS.API.Domains;
using System.Threading.Tasks;

namespace Senai.HROADS.API.Interfaces
{
    interface ITipoHabilidadeRepository
    {
        List<TipoHabilidadeDomain> Listar();
        TipoHabilidadeDomain BuscarPorId();
        void Cadastrar(TipoHabilidadeDomain novoTipoHabilidade);
        void Atualizar(int id, TipoHabilidadeDomain TipoHabilidadeAtualizada);
        void Deletar(int id);
    }
}
