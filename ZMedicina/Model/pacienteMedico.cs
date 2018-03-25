using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class pacienteMedico
    {
        public int PacienteID { get; set; }

        public Paciente Paciente { get; set; }

        public int MedicoID { get; set; }

        public Medico Medico { get; set; }

    }
}
