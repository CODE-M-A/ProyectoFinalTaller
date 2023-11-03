using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartamentoController : ControllerBase
    {
        private readonly ILogger<DepartamentoController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public DepartamentoController(
            ILogger<DepartamentoController> logger, 
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        [Route("idDepartamento")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Departamento departamento)
        {
            _aplicacionContexto.Departamento.Add(departamento);
            _aplicacionContexto.SaveChanges();
            return Ok(departamento);
        }
        //READ: Obtener lista de estudiantes
        [Route("idDepartamento")]
        [HttpGet]
        public IEnumerable<Departamento> Get()
        {
            return _aplicacionContexto.Departamento.ToList();
        }
        //Update: Modificar estudiantes
        [Route("/idDepartartamento")]
        [HttpPut]
        public IActionResult Put([FromBody] Departamento departamento)
        {
            _aplicacionContexto.Departamento.Update(departamento);
            _aplicacionContexto.SaveChanges();
            return Ok(departamento);
        }
        //Delete: Eliminar Empleado
        [Route("/idDepartamento")]
        [HttpDelete]
        public IActionResult Delete(int departamentoID)
        {
            _aplicacionContexto.Departamento.Remove(
                _aplicacionContexto.Departamento.ToList()
                .Where(x=>x.idDepartamento== departamentoID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(departamentoID);
        }
    }
}