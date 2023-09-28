using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Clase2.Models
{
    public class Cliente
    {
        [ReadOnly(true)]
        public int IdCliente { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Por favor, informar el nombre")]
        public string? Nombre { get; set; }

        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "Por favor, informar el apellido")]
        public string? Apellido { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        [Display(Name= "Fecha de Nacimiento")]
        [Required(ErrorMessage ="Por favor, ingresa la fecha de nacimiento")]
        public DateTime? FechaDeNacimiento { get; set; }

        public bool Activo {get; set;}
        [Display(Name = "Cantidad días de vencimiento")]
        [Required(ErrorMessage = "Por favor, ingrese la cantidad de días vencimiento")]
        public float? CantidadDias { get; set; }

        [Display(Name = "Observación")]
        [DataType(DataType.MultilineText)]
        public string? Observación { get; set; }

    }
}
