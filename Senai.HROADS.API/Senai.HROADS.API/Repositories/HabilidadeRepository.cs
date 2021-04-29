using System;
using Senai.HROADS.API.Interfaces;
using Senai.HROADS.API.Domains;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Senai.HROADS.API.Controllers;

namespace Senai.HROADS.API.Repositories
{
    public class HabilidadeRepository : IHabilidadeRepository
    {
        public void Atualizar(int id, HabilidadeDomains habilidadeAtualizada)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(int id, HabilidadesController habilidadeAtualizado)
        {
            throw new NotImplementedException();
        }

        public HabilidadeDomains BuscarPorId()
        {
            throw new NotImplementedException();
        }

        public object BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(HabilidadeDomains NovaHabilidade)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(HabilidadesController novoHabilidade)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<HabilidadeDomains> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
