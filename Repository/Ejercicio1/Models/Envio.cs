
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Net.NetworkInformation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio1.Models
{

    [Table("Envios")]
    public class Envio
    {
        [Key]
        public int Id { get; set; }

        [Column("Valor_Total")]
        public double ValorTotal { get; set; }

        //virtual para carga lazy
        virtual public List<Costo> Costos { get; set; } = new List<Costo>();
                
    }
}
