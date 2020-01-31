using System;
using System.ComponentModel.DataAnnotations;

namespace Aplicacion.Web.Models.Permiso
{
    public class CrearViewModel
    {
        public int id_tipo_permiso { get; set; }
        [Required]
        [StringLength(30)]
        public string nombre_empleado { get; set; }
        [Required]
        [StringLength(50)]
        public string apellidos_empleado { get; set; }
        [Required]
        public DateTime fecha_permiso { get; set; }
    }
}