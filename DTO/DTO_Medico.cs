using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace DTO
{
    class DTO_Medico
    {
        private int idMedico, CRM;
        private string nomeMedico;

        public int idmedico
        {
            get { return idMedico; }

            set { idMedico = value; }
        }

        public string nomemedico
        {
            get { return nomeMedico; }

            set { nomeMedico = value; }
        }

        public int crm
        {
            get { return CRM;}
        
            set { CRM = value; }
        }
    }
}
