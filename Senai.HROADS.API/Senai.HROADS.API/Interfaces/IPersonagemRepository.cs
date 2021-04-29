using System;
using Senai.HROADS.API.Domains;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Senai.HROADS.API.Repositories;

namespace Senai.HROADS.API.Interfaces
{
    interface IPersonagemRepository
    {
        List<PersonagemDomain> Listar();
        PersonagemDomain BuscarPorId();
        void Cadastrar(PersonagemDomain novoPersonagem);
        void Atualizar(int id, PersonagemDomain PersonagemAtualizado);
        void Deletar(int id);
        object BuscarPorId(int id);
        void Atualizar(int id, PersonagemRepository personagemAtualizado);
        void Cadastrar(PersonagemRepository novoPersonagem);
    }
}
