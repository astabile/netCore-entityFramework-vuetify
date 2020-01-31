using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Aplicacion.Datos;
using Aplicacion.Entidades;
using System.Collections.Generic;
using Aplicacion.Web.Models.Permiso;
using System;

namespace Aplicacion.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermisosController : ControllerBase
    {
        private readonly DbContextAplicacion _context;

        public PermisosController(DbContextAplicacion context)
        {
            _context = context;
        }

        // GET: api/Permisos/Listar
        [HttpGet("[action]")]
        public async Task<IEnumerable<PermisoViewModel>> Listar()
        {
            var permisos = await _context.Permiso.Include(p => p.TipoPermiso).ToListAsync();
            return permisos.Select(p => new PermisoViewModel 
            {
                id = p.id,
                id_tipo_permiso = p.id_tipo_permiso,
                tipo_permiso = p.TipoPermiso.descripcion,
                nombre_empleado = p.nombre_empleado,
                apellidos_empleado = p.apellidos_empleado,
                fecha_permiso = p.fecha_permiso
            });
        }

        // POST: api/Permisos/Crear
        [HttpPost("[action]")]
        public async Task<IActionResult> Crear([FromBody] CrearViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Permiso permiso = new Permiso
            {
                id_tipo_permiso = model.id_tipo_permiso,
                nombre_empleado = model.nombre_empleado,
                apellidos_empleado = model.apellidos_empleado,
                fecha_permiso = model.fecha_permiso
            };

            _context.Permiso.Add(permiso);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

            return Ok();
        }

        // DELETE: api/Permisos/Eliminar/1
        [HttpDelete("[action]/{id}")]
        public async Task<IActionResult> Eliminar([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var permiso = await _context.Permiso.FindAsync(id);
            if (permiso == null)
            {
                return NotFound();
            }

            _context.Permiso.Remove(permiso);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

            return Ok(permiso);
        }

        private bool PermisosExists(int id)
        {
            return _context.Permiso.Any(e => e.id == id);
        }
    }
}