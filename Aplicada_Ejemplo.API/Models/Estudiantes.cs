using System;
using System.ComponentModel.DataAnnotations;

namespace Aplicada_Ejemplo.Api.Models
{
    public class Estudiantes
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe poner un nombre"), MaxLength(200)]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "Debe poner un semestre"), Range(minimum: 1, maximum: 12)]
        public int Semestre { get; set; }
        [Required(ErrorMessage = "Debe poner una nacionalidad")]
        public string Nacionalidad { get; set; }
    }
}
