using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

namespace WebApplication2.Models
{
    public class Seguro
    {
        [Key]
        public int IdSeguro { get; set; }
        public string Tipo { get; set; }
        public int Importe { get; set; }
        public int FechaImporte { get; set; }




    }
}