using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Session5.Data
{
    public class Secreto
    {
        public int SecretoId { get; set; }

        [Required(ErrorMessage = "El titulo es requerido")]
        [StringLength(50, ErrorMessage = "Titulo muy largo (50 caracteres maximo).")]
        [Display(Name = "Titulo del secreto", Prompt ="Titulo")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "La descripcion es requerida")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El lugar es requerido")]
        public string Lugar { get; set; }
        
        public DateTime Fecha { get; set; }
        
        public decimal ValorMonetario{ get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public Usuario User { get; set; }
    }
}
