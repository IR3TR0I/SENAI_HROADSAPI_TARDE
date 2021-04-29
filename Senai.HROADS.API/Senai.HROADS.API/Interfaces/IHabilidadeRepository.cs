using System;
using System.Collections.Generic;
using System.Linq;
using Senai.HROADS.API.Domains;
using System.Threading.Tasks;
using Senai.HROADS.API.Controllers;

namespace Senai.HROADS.API.Interfaces
{
    interface IHabilidadeRepository
    {
        List<HabilidadeDomains> Listar();
        HabilidadeDomains BuscarPorId();
        void Cadastrar(HabilidadeDomains NovaHabilidade);
        void Atualizar(int id, HabilidadeDomains habilidadeAtualizada);
        void Deletar(int id);
        void Cadastrar(HabilidadesController novoHabilidade);
        void Atualizar(int id, HabilidadesController habilidadeAtualizado);
        object BuscarPorId(int id);
    }
}
