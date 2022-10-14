using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;
using PRUEBA_TECNICA_5.Models;

namespace PRUEBA_TECNICA_5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotasController : ControllerBase
    {
        public readonly DBESCUELAContext dBESCUELAContext;

        public NotasController(DBESCUELAContext dBESCUELAContext)
        {
            this.dBESCUELAContext = dBESCUELAContext;
        }

        [HttpGet]
        [Route("listarDiezPrimerasNotas")]
        public IActionResult listar()
        {
            List<Nota> lista = new List<Nota>();

            try
            {
                lista = dBESCUELAContext.Notas.Include(e => e.oEstudiante).Include(m => m.oMateria).Include(p => p.oPeriodo).ToList();
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "Ok", response = lista.Take(10) });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message, response = lista });
            }
        }
    }
}
