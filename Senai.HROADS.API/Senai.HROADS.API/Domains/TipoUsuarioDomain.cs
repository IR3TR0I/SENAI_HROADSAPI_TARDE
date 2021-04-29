using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.HROADS.API.Domains
{
    public class TipoUsuarioDomain
    {
        public int IdTipoUsuario { get; set; }

        [Required(ErrorMessage = "O Titulo do tipo de usuario é necessario")]
        public string Titulo { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
