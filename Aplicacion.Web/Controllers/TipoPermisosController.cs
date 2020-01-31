using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aplicacion.Datos;
using Aplicacion.Web.Models.TipoPermiso;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoPermisosController : ControllerBase
    {
        private readonly DbContextAplicacion _context;

        public TipoPermisosController(DbContextAplicacion context)
        {
            _context = context;
        }

        // GET: api/TipoPermisos/Listar
        [HttpGet("[action]")]
        public async Task<IEnumerable<TipoPermisoViewModel>> Listar()
        {
            var tipoPermiso = await _context.TipoPermiso.ToListAsync();
            return tipoPermiso.Select(t => new TipoPermisoViewModel
            {
                id = t.id,
                descripcion = t.descripcion
            });
        }

        // GET: api/TipoPermisos/Mostrar/1
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> Mostrar([FromRoute] int id)
        {

            var tipoPermiso = await _context.TipoPermiso.FindAsync(id);

            if (tipoPermiso == null)
            {
                return NotFound();
            }

            return Ok(new TipoPermisoViewModel
            {
                id = tipoPermiso.id,
                descripcion = tipoPermiso.descripcion
            });
        }

        private bool TipoPermisoExists(int id)
        {
            return _context.TipoPermiso.Any(e => e.id == id);
        }
    }
}