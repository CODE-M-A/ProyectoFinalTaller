using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Empleado
    {
        [Key]
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Area { get; set; }
    }
}
