using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contagto.Models
{
  public class Calculo
  {
    public string? Operacion { get; set; }
    public double Numero1 { get; set; }
    public double Numero2 { get; set; }
    public double Resultado { get; set; }
     public double Calcular()
    {
      double resultado = 0;
      
        switch (Operacion)
        {
          case "sumar":
            resultado = Numero1 + Numero2;
            break;
          case "restar":
            resultado = Numero1 - Numero2;
            break;
          case "multiplicar":
            resultado = Numero1 * Numero2;
            break;
          case "dividir":
            if (Numero2 != 0)
            {
              resultado = Numero1 / Numero2;
            }
            else
            {
              throw new DivideByZeroException("No se puede dividir por cero");
            }
            break;
          default:
                    throw new InvalidOperationException("Operación no válida");

        }
        return resultado;
      
    }
  }


    } 
