using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Org.BouncyCastle.Bcpg.OpenPgp;
using DAL;
using DTO;

namespace BLL
{
    class BLL_Medico
    {
        conexao bd = new conexao();

        public void AlterarMedico(DTO_Medico DTOMedico)
        {
            try
            {
                string sql = String.Format("UPDATE Medicos SET nomeMedico = '{0}', CRM = '{1}' WHERE idMedico = '{2}'", DTOMedico.nomemedico, DTOMedico.crm, DTOMedico.idmedico);
                bd.executarComando(sql);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InserirMedico(DTO_Medico DTOMedico)
        {
            try
            {
                string sql = String.Format("INSERT INTO Medicos (nomeMedico, CRM) VALUES ('{0}', '{1}')", DTOMedico.nomemedico, DTOMedico.crm);
                bd.executarComando(sql);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirMedico(int id)
        {
            try
            {
                string sql = String.Format("DELETE FROM Medicos WHERE idMedico = '{0}'", id);
                bd.executarComando(sql);
            }
            
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ExibirMedicos()
        {
            try
            {
                string sql = "SELECT * FROM Medicos;";
                return bd.ExecutarConsulta(sql);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
