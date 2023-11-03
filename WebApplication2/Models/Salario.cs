using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

namespace WebApplication2.Models
{
    public class Salario
    {
        [Key]
        public int IdSalario { get; set; }
        public int Salario { get; set; }
        public int FechaInicio { get; set; }
        



    }
}
