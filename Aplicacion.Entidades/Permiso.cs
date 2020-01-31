using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacion.Entidades
{
    public class Permiso
    {
        public int id { get; set; }
        [Required]
        public int id_tipo_permiso { get; set; }
        [Required]
        [StringLength(30)]
        public string nombre_empleado { get; set; }
        [Required]
        [StringLength(50)]
        public string apellidos_empleado { get; set; }
        [Required]
        public DateTime fecha_permiso { get; set; }

        //EF
        [ForeignKey("id_tipo_permiso")]
        public TipoPermiso TipoPermiso { get; set; }
    }
}
