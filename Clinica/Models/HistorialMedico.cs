using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinica.Models
{
    public class HistorialMedico
    {
        [Key]
        [ForeignKey("Paciente")]
        public int PacienteId { get; set; }

        [StringLength(1000, ErrorMessage = "El historial no puede exceder 1000 caracteres.")]
        [Display(Name = "Alergias Conocidas")]
        public string? Alergias { get; set; }

        [StringLength(1000, ErrorMessage = "Las condiciones médicas no pueden exceder 1000 caracteres.")]
        [Display(Name = "Condiciones Médicas")]
        public string? CondicionesMedicas { get; set; }

        [StringLength(1000, ErrorMessage = "Las notas del historial no pueden exceder 1000 caracteres.")]
        public string? Notas { get; set; }

        [Required(ErrorMessage = "El historial debe estar asociado a un paciente.")]
        public Paciente Paciente { get; set; }
    }
}