using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ML
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }

        [Required (ErrorMessage ="{0} El campo es requerido")]
        public string Nombre { get; set; }
        [Required]
        public string ApellidoPaterno { get; set; }
        [Required]
        public string ApellidoMaterno { get; set; }
        [Required]
        public int Edad { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        public List<object> EmpleadoList { get;set; }
    }
}
