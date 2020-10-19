using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session5.Data
{
    public class Secreto
    {
        public int SecretoId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Lugar { get; set; }
        public DateTime Fecha { get; set; }
        public decimal ValorMonetario{ get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public int UsuarioId { get; set; }
        public Usuario User { get; set; }
    }
}
