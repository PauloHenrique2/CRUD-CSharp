using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_Consulta
    {
        private int idConsulta;
        private string dataConsulta, horaInicio, horaFim, obs;

        public int idconsulta
        {
            get { return idConsulta; }

            set { idConsulta = value; } 
        }

        public string dataconsulta
        {
            get { return dataConsulta; }
        
            set { dataConsulta = value; }
        }   

        public string horainicio
        {
            get { return horaInicio; }

            set { horaInicio = value; }
        }

        public string horafim
        {
            get { return horaFim; }

            set { horaFim = value; }
        }

        public string Obs
        {
            get { return obs; }

            set { obs = value; }
        }
    }
}
