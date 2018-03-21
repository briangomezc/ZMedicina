using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Paciente
    {
        [Key]
        public int PacienteID { get; set; }
        
        public string Cedula { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }
        
        public DateTime Fecha { get; set; }
        
        public string Pass { get; set; }
        
        public string Email { get; set; }
        
        public string sexo { get; set; }
        
        public string Telefono { get; set; }
        
        public string Celular { get; set; }

        public int? MedicoID { get; set; } 

        public Medico Medico { get; set; }
    }
}
