using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinica.Models
{
    public class Paciente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio.")]
        [StringLength(100, ErrorMessage = "El apellido no puede exceder 100 caracteres.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria.")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [EmailAddress(ErrorMessage = "Ingrese un correo electrónico válido.")]
        [Display(Name = "Correo Electrónico")]
        public string? CorreoElectronico { get; set; }

        [StringLength(20, ErrorMessage = "El teléfono no puede exceder 20 caracteres.")]
        public string? Telefono { get; set; }

        // Propiedad de navegación para la relación 1 a muchos con Citas
        public ICollection<Cita>? Citas { get; set; }

        // Propiedad de navegación para la relación 1 a 1 con HistorialMedico
        public HistorialMedico? Historial { get; set; }
    }
}