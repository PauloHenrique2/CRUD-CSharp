using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class BLL_Consulta
    {
        conexao bd = new conexao();

        public void InserirConsulta(DTO_Consulta DTOConsulta)
        {
            try
            {
                string sql = String.Format("INSERT INTO Consultas (dataConsulta, horaInicio, horaFim, obs) VALUES ('{0}', '{1}', '{2}', '{3}')", DTOConsulta.dataconsulta, DTOConsulta.horainicio, DTOConsulta.horafim, DTOConsulta.Obs);
                bd.executarComando(sql);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirConsulta(int id)
        {
            try
            {
                string sql = String.Format("DELETE FROM Consultas WHERE idConsulta = '{0}'", id);
                bd.executarComando(sql);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ExibirConsultas()
        {
            try
            {
                string sql = "SELECT * FROM Consultas;";
                return bd.ExecutarConsulta(sql);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
