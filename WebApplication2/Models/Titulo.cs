using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

namespace WebApplication2.Models
{
    public class Titulo
    {
        [Key]
        public int IdTitulo { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }




    }
}