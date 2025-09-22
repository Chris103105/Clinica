using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinica.Models
{
    public class Medico
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio.")]
        [StringLength(100, ErrorMessage = "El apellido no puede exceder 100 caracteres.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "La especialidad es obligatoria.")]
        [StringLength(100, ErrorMessage = "La especialidad no puede exceder 100 caracteres.")]
        public string Especialidad { get; set; }

        [StringLength(20, ErrorMessage = "El número de licencia no puede exceder 20 caracteres.")]
        [Display(Name = "Número de Licencia")]
        public string? NumeroLicencia { get; set; }

        // Propiedad de navegación para la relación 1 a muchos con Citas
        public ICollection<Cita>? Citas { get; set; }
    }
}