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

        
    }
}
