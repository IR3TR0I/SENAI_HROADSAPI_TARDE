using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.HROADS.API.Domains
{
    public class Usuario
    {
        public int IdUsuario { get; set; }


        [Required(ErrorMessage = "O email é obrigatório")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "A senha é obrigatório")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [Required(ErrorMessage = "O id do tipo de usuario é obrigatório")]
        public int IdTipoUsuario { get; set; }

        public virtual TipoUsuarioDomain IdTipoUsuarioNavigation { get; set; }
    }
}
