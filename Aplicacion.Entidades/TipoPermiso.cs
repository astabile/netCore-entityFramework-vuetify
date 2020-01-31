using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Aplicacion.Entidades
{
    public class TipoPermiso
    {
        public int id { get; set; }
        [Required]
        [StringLength(256)]
        public string descripcion { get; set; }

        //EF
        public ICollection<Permiso> Permiso { get; set; }
    }
}
