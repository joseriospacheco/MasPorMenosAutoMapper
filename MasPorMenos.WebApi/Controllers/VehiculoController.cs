using Dominio.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servicio.Interfaces;

namespace MasPorMenos.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoController : ControllerBase
    {
        private readonly IVehiculoService _service;

        public VehiculoController(IVehiculoService service)
        {
            _service = service;
        }
        [HttpPost]
        public ActionResult Crear([FromBody] CrearVehiculoDto dto) {

            _service.Registrar(dto);
            return Ok();
            
            
        }
    }
}
