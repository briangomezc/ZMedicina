using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    public class Medico
    {
        [Key]
        public int MedicoID { get; set; }

        public string Cedula { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public DateTime Fecha { get; set; }

        public string Pass { get; set; }

        public string Email { get; set; }

        public string sexo { get; set; }

        public string TipoMedico { get; set; }

        public string Especializaciones { get; set; }

        public string Telefono { get; set; }

        public string Celular { get; set; }

    }
}
