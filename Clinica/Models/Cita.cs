using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinica.Models
{
    public class Cita
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "La fecha y hora de la cita es obligatoria.")]
        [Display(Name = "Fecha y Hora")]
        public DateTime FechaHora { get; set; }

        [StringLength(500, ErrorMessage = "Las notas no pueden exceder 500 caracteres.")]
        public string? Notas { get; set; }

        [Required(ErrorMessage = "El paciente es obligatorio.")]
        [Display(Name = "Paciente")]
        public int PacienteId { get; set; }

        [ForeignKey("PacienteId")]
        public Paciente? Paciente { get; set; }

        [Required(ErrorMessage = "El médico es obligatorio.")]
        [Display(Name = "Médico")]
        public int MedicoId { get; set; }

        [ForeignKey("MedicoId")]
        public Medico? Medico { get; set; }
    }
}