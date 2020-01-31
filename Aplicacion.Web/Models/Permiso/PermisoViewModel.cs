using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Aplicacion.Web.Models.Permiso
{
    public class PermisoViewModel
    {
        public int id { get; set; }
        public int id_tipo_permiso { get; set; }
        public string tipo_permiso { get; set; }
        public string nombre_empleado { get; set; }
        public string apellidos_empleado { get; set; }
        [JsonConverter(typeof(DateFormatConverter))]
        public DateTime fecha_permiso { get; set; }
    }

    public class DateFormatConverter : IsoDateTimeConverter
    {
        public DateFormatConverter()
        {
            DateTimeFormat = "dd/MM/yyyy";
        }
    }
}