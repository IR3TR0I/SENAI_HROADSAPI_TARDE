using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.HROADS.API.Domains
{
    public class PersonagemDomain
    {
        public int IdPersonagem { get; set; }
        public int? IdClasse { get; set; }
        public string NomePersonagem { get; set; }
        public int? VidaMaxima { get; set; }
        public int ManaMaxima { get; set; }
        public DateTime DataCriação { get; set; }
        public DateTime DataAtualização { get; set; }

        public virtual ClasseDomain IdClasseNavigation { get; set; }
    }
}
