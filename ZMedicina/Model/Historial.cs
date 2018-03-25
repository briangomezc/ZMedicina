using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;
using Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Service;

namespace Model
{
    public class Historial
    {
        [Key]
        public int HistorialID { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string Cedula { get; set; }

        public int Edad { get; set; }

        public string sexo { get; set; }

        public string Seguro { get; set; }

        public string Ocupacion { get; set; }

        public string Telefono { get; set; }

        public string Celular { get; set; }

        public string Direccion { get; set; }

        public string Sintomas { get; set; }

        public string Antecedentes { get; set; }

        public int PacienteID { get; set; }

        public Paciente Paciente { get; set; }

        public int MedicoID { get; set; }

        public Medico Medico { get; set; }


    }
}
