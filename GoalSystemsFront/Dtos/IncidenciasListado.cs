using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace GoalSystemsFront.Dtos
{
    public class IncidenciasListado
    {
        public int id { get; set; }
        public string nombreEmpleado { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaAlta { get; set; }
    }
}