using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.HROADS.API.Domains
{
    public class ClasseDomain
    {
        public int IdClasse { get; set;}

        public string nomeClasse { get; set;}
        
        public virtual ICollection<PersonagemDomain> Personagems { get; set; }
    }
}
