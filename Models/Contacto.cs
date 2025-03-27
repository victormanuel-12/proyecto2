using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace contagto.Models
{
  public class Contacto
  {
    [Required(ErrorMessage = "Por favor, ingrese su nombre.")]
    public string? Nombre { get; set; }
    
    [Required(ErrorMessage = "Por favor, ingrese su correo electrónico.")]
    [EmailAddress(ErrorMessage = "Por favor, ingrese un correo electrónico válido.")]
    public string? Email { get; set; }
    
    [Required(ErrorMessage = "Por favor, ingrese su mensaje.")]
    public string? Mensaje { get; set; }
  }
}