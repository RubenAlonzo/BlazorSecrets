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

        [Required(ErrorMessage = "EL Titulo es requerido")]
        [StringLength(50, ErrorMessage = "Titulo muy largo (50 caracteres maximo).")]
        [Display(Name = "Titulo del secreto", Prompt ="Titulo")]
        public string Titulo { get; set; }
        
        [Required]
        public string Descripcion { get; set; }
        
        [Required]
        public string Lugar { get; set; }
        
        public DateTime Fecha { get; set; }
        
        [Display(Name ="Precio", Prompt = "0 DOP")]
        
        public decimal ValorMonetario{ get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public Usuario User { get; set; }
    }
}
