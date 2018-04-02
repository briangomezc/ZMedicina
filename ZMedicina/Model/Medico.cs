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

        public string Tipo { get; set; }

        public string Especializaciones { get; set; }

        public string Telefono { get; set; }

        public string Celular { get; set; }

        public string Foto { get; set; }

        public string Usuario { get; set; }

        public IList<pacienteMedico> pacienteMedico { get;set; }

        public IList<Historial> Historial { get; set; }

        public IList<Cita> Cita { get; set; }

    }
}
