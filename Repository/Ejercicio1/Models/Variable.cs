
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ejercicio1.Models
{
    public class Variable:Costo
    {
        [Column("Precio_Por_Unidad")]
        [DefaultValue(0.0)]
        public double PrecioPorUnidad { get; set; }

        [Column("Unidades")]
        [DefaultValue(0.0)]
        public double Unidades { get; set; }

        public override string ToString()
        {
            return $"Variable {Concepto} {ValorFinal:f2}({PrecioPorUnidad}/{Unidades})";
        }
    }
}
