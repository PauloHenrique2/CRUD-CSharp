using DTO;
using DAL;
using Hospital;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BLL
{
    class BLL_Paciente
    {
        conexao bd = new conexao();

        public void AlterarPaciente(DTO_Paciente DTOPaciente)
        {
            try
            {
                string sql = string.Format("UPDATE Pacientes SET nomePaciente = '{0}', telefone = '{1}' WHERE idPaciente = '{2}';", DTOPaciente.nomepaciente, DTOPaciente.Telefone, DTOPaciente.idpaciente);
                bd.executarComando(sql);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void InserirPaciente(DTO_Paciente DTOPaciente)
        {
            try
            {
                string sql = String.Format("INSERT INTO Pacientes (nomePaciente, telefone) VALUES ('{0}', '{1}')", DTOPaciente.nomepaciente, DTOPaciente.Telefone);
                bd.executarComando(sql);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirPaciente(int id)
        {
            try
            {
                string sql = String.Format("DELETE FROM Pacientes WHERE idPaciente = '{0}'", id);
                bd.executarComando(sql);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ExibirPacientes()
        {
            try
            {
                string sql = "SELECT * FROM Pacientes;";
                return bd.ExecutarConsulta(sql);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ExibirPacientesComId(int id)
        {
            try
            {
                string sql = String.Format("SELECT * FROM Pacientes WHERE idPaciente = '{0}';", id);
                return bd.ExecutarConsulta(sql);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
