

using System.ComponentModel.DataAnnotations.Schema;

namespace Ejercicio1.Models
{
    
    public class Fijo:Costo
    {
        public override string ToString()
        {
            return $"Fijo: {Concepto} {ValorFinal:f2}";
        }
    }
}
