using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session5.Data
{
    public class Usuario: IdentityUser
    {
        public List<Secreto> Secretos { get; set; }
        [PersonalData]
        public string Cedula { get; set; }
        [PersonalData]
        public string Nombre { get; set; }
        [PersonalData]
        public string Apellido { get; set; }
        [PersonalData]
        public string Foto { get; set; }

    }
}
