using Senai.HROADS.API.Domains;
using Senai.HROADS.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.HROADS.API.Repositories
{
    public class PersonagemRepository : IPersonagemRepository
    {
        public void Atualizar(int id, PersonagemDomain PersonagemAtualizado)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(int id, PersonagemRepository personagemAtualizado)
        {
            throw new NotImplementedException();
        }

        public PersonagemDomain BuscarPorId()
        {
            throw new NotImplementedException();
        }

        public object BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(PersonagemDomain novoPersonagem)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(PersonagemRepository novoPersonagem)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<PersonagemDomain> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
