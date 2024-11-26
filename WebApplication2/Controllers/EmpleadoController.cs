using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmpleadoController : ControllerBase
    {
        private readonly ILogger<EmpleadoController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public EmpleadoController(
            ILogger<EmpleadoController> logger, 
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        [Route("/idEmpleado")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Empleado empleado)
        {
            _aplicacionContexto.Empleado.Add(empleado);
            _aplicacionContexto.SaveChanges();
            return Ok(empleado);
        }
        //READ: Obtener lista de estudiantes
        [Route("/idEmpleado")]
        [HttpGet]
        public IEnumerable<Empleado> Get()
        {
            return _aplicacionContexto.Empleado.ToList();
        }
        //Update: Modificar estudiantes
        [Route("/idEmpleado")]
        [HttpPut]
        public IActionResult Put([FromBody] Empleado empleado)
        {
            _aplicacionContexto.Empleado.Update(empleado);
            _aplicacionContexto.SaveChanges();
            return Ok(empleado);
        }
        //Delete: Eliminar estudiantes
        [Route("/idEmpleado")]
        [HttpDelete]
        public IActionResult Delete(int empleadoID)
        {
            _aplicacionContexto.Empleado.Remove(
                _aplicacionContexto.Empleado.ToList()
                .Where(x=>x.IdEmpleado== empleadoID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(empleadoID);
        }
    }
}