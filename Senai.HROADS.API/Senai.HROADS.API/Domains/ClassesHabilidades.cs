using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.HROADS.API.Domains
{
    public class ClassesHabilidades
    {
        public int IdClasse { get; set; }
        public int IdHabilidade { get; set; }

        public string NomeHabilidade { get; set; }

        public virtual TipoHabilidadeDomain IdTipoHabilidadeNavigation { get; set; }
    }
}
