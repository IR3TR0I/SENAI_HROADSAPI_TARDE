using System;
using System.Collections.Generic;
using System.Linq;
using Senai.HROADS.API.Domains;
using System.Threading.Tasks;

namespace Senai.HROADS.API.Interfaces
{
    interface IClasseRepository
    {
        List<ClasseDomain> Listar();

        ClasseDomain BuscarPorId();
        void Cadastrar(ClasseDomain NovaClasse);
        void atualizar(int Id, ClasseDomain ClasseAtualizada);
        void Deletar(int Id);
        object BuscarPorId(int id);
    }
}
