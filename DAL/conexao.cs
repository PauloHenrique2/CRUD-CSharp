using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using Org.BouncyCastle.Asn1;
using System.Drawing;
using System.Windows.Forms;

namespace DAL
{
    class conexao
    {
        public MySqlConnection conecta;

        public string conectar()
        {
            try
            {
                conecta = new MySqlConnection("server = localhost; uid = root; database = hospital; pwd=");
                conecta.Open();
                return "Conexão estabelecida com successo!";
            }

            catch (MySqlException)
            {
                throw new Exception("Ocorreu um erro ao conectar!");
            }
        }

        public void executarComando(string sql)
        {
            try
            {
                conectar();
                MySqlCommand cmd = new MySqlCommand(sql, conecta);
                cmd.ExecuteNonQuery();
            }

            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            finally
            {
                conecta.Close();
            }
        }

        public bool verificaConsulta(string sql)
        {
            conectar();
            MySqlCommand cmd = new MySqlCommand(sql, conecta);

            if (cmd.ExecuteScalar() == null)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public DataTable ExecutarConsulta(string sql)
        {
            try
            {
                conectar();
                MySqlDataAdapter consulta = new MySqlDataAdapter(sql, conecta);
                DataTable dados = new DataTable();
                consulta.Fill(dados);

                return dados;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conecta.Close();
            }
        }
    }
}
