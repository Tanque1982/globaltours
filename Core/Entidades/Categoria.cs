using System.ComponentModel.DataAnnotations;

namespace Core.Entidades
{
    public class Categoria
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }

    }
}