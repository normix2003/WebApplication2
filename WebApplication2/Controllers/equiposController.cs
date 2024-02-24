using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class equiposController : ControllerBase
    {
        private readonly equiposContext _equiposContext;
        public equiposController(equiposContext equiposContext)
        {
            _equiposContext = equiposContext;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get() 
        {
          List<Equipos> ListadoEquipo = (from e in _equiposContext.Equipos 
                                         select e).ToList();
                if (ListadoEquipo.Count == 0)
                    { return NotFound(); }

            return Ok(ListadoEquipo);
        
        }


    }
}
