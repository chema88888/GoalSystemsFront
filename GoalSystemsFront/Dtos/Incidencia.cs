using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GoalSystemsFront.Dtos
{
    public class Incidencia
    {
        public int Id { get; set; }
        public int IdEmpleado { get; set; }
        [ForeignKey("IdEmpleado")]
        public string Descripcion { get; set; }
        public DateTime FechaAlta { get; set; }
    }
}