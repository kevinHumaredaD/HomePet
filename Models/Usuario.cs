using System.ComponentModel.DataAnnotations;

namespace HomePet.Models
{
    public class Usuario
    {
        [Required]
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        [Required]
        public int Edad { get; set; }        
        [EmailAddress]
        public string Email { get; set; }   
        public string Foto {get; set;}     
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        
    }
}