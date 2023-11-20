using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_Paciente
    {
        private int idPaciente;
        private string nomePaciente, telefone;

        public int idpaciente
        { 
          get { return idPaciente; }

          set { idPaciente = value; }
        }


        public string nomepaciente
        {
            get { return nomePaciente; }

            set { nomePaciente = value; }
        }

        public string Telefone
        {
            get {return telefone;}

            set { telefone = value; }
        }
    }
}
