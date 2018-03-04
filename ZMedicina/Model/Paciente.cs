using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Paciente
    {
        [Key]
        public int PacienteID { get; set; }

        [Required(ErrorMessage = "Tu debes ingresar {0}.")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "Tu debes ingresar {0}.")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener {2} caracteres minimo y {1} caracteres maximo.", MinimumLength = 3)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Tu debes ingresar {0}.")]
        [StringLength(30, ErrorMessage = "El campo {0} debe tener {2} caracteres minimo y {1} caracteres maximo.", MinimumLength = 3)]
        public string Apellidos { get; set; }

        [Display(Name = "Fecha de Cumpleaños")]
        [Required(ErrorMessage = "Tu debes ingresar {0}.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string Pass { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Tu debes ingresar un {0}.")]
        public string sexo { get; set; }

        [Required(ErrorMessage = "Tu debes ingresar un {0}.")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Tu debes ingresar un {0}.")]
        public string Celular { get; set; }

        [NotMapped]
        public int Age { get { return DateTime.Now.Year - Fecha.Year; } }
    }
}
