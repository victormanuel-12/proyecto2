using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace contagto.Models
{
  public class Customer
  {
    public string UserName { get; set; }
    [Required(ErrorMessage = "DNI es requerido")]
    public string DNI { get; set; }
    [Required(ErrorMessage = "Fecha de nacimiento es requerido")]
    public DateTime BirthDate { get; set; }
    [Required(ErrorMessage = "Direccion es requerido")]
    public string Address { get; set; }
    
  }
}