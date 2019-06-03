using System.ComponentModel.DataAnnotations;

namespace HomePet.Models
{
    public class Mascota
    {
        
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Raza { get; set; }
        [Required]
        public int Edad { get; set; }
        [Required]
        public string tamaño{ get; set; }  
        public string TipoPelo { get; set; }
        [Required]
        public string Foto { get; set; }
        
    }
}