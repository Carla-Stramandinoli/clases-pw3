using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using primerFormWindows.Entidad;
using primerFormWindows.Logica;

namespace primerFormWindows.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReseniasController : ControllerBase
    {
        IReseniaServicio _reseniaServicio;

        public ReseniasController(IReseniaServicio reseniaServicio)
        {
            _reseniaServicio = reseniaServicio;
        }

        [HttpGet]
        public IActionResult GetResenia()
        {
            return Ok(_reseniaServicio.OtenerResenias());
        }

        [HttpPost]
        public IActionResult PostResenia([FromBody] Resenia resenia) 
        {
           _reseniaServicio.AgregarResenia(resenia);
            return Ok();
        }
    }
}
