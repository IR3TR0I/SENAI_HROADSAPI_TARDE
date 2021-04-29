using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.HROADS.API.Domains
{
    public class TipoHabilidadeDomain
    {
        public int IdTipohabilidade { get; set; }
        public string TipoHabilidade { get; set; }

        public virtual ICollection<HabilidadeDomains> Habilidades { get; set; }
    }
}
