using System;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;
using Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Service;

namespace Model
{
    public class Cita
    {
        [Key]
        public int CitaID { get; set; }

        public string Fecha { get; set; }

        public string Tipo { get; set; }

        public int PacienteID { get; set; }

        public Paciente Paciente { get; set; }

        public int MedicoID { get; set; }

        public Medico Medico { get; set; }
    }
}
