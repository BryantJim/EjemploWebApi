using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aplicada_Ejemplo.Api.Data;
using Aplicada_Ejemplo.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace Aplicada_Ejemplo.Api.Controllers
{
    [Route(template:"api/[Controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        private Contexto contexto;

        public EstudiantesController(Contexto contexto)
        {
            this.contexto = contexto;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Estudiantes>>> Get()
        {
            List<Estudiantes> estudiantes;
            try
            {
               estudiantes = await contexto.Estudiantes.ToListAsync();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return estudiantes;
        }

        private async Task<ActionResult<bool>> Insertar(Estudiantes estudiante)
        {
            bool guardar = false;
            try
            {
                if(contexto.Estudiantes.Add(estudiante) != null)
                {
                    guardar = await contexto.SaveChangesAsync() > 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return guardar;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Action>> Delete(int id)
        {
            try
            {
                var estudiante = await contexto.Estudiantes.Where(d => d.Id == id).SingleOrDefaultAsync();

                if (estudiante == null)
                    return NotFound("Estudiantes no encontrado");
                else
                {
                    contexto.Estudiantes.Remove(estudiante);
                    await contexto.SaveChangesAsync();
                    return Ok("Estudiante eliminado");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Estudiantes>> GetId(int id)
        {
            try
            {
                var estudiante = await contexto.Estudiantes.Where(d => d.Id == id).SingleOrDefaultAsync();

                if (estudiante == null)
                    return NotFound("Estudiantes no encontrado");
                else
                    return Ok(estudiante);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private async Task<ActionResult<bool>> Modificar([FromBody]Estudiantes estudiante)
        {
            bool modificar = false;
            try
            {
                contexto.Estudiantes.Update(estudiante);
                modificar = await contexto.SaveChangesAsync() > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return modificar;
        }

        [HttpPost]     
        public async Task<ActionResult<bool>> Guardar(Estudiantes estudiante)
        {
            bool existe;
            try
            {
                existe = await contexto.Estudiantes.AnyAsync(a => a.Id == estudiante.Id);

                if (existe)
                   return await Modificar(estudiante);
                else
                    return await Insertar(estudiante);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


    }
}
