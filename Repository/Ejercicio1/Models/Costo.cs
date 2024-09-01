

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ejercicio1.Models
{
    [Table("Costos")]
    abstract public class Costo
    {
        [Key]
        public int Id { get; set; }

        [StringLength(200)]
        [Column("Concepto")]
        public string Concepto { get; set; }

        [Column("Valor_Final")]
        [DefaultValue(0)]
        public double ValorFinal { get; set; }

        [ForeignKey("Envio")]
        [Column("Id_Envio")]
        public int EnvioId { get; set; }
        virtual public Envio Envio { get; set; }

        public override string ToString()
        {
            return $"{this.GetType()}";
        }
    }
}
