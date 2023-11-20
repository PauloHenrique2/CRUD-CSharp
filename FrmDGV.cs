using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class FrmDGV : Form
    {
        public FrmDGV()
        {
            InitializeComponent();
        }

        conexao con = new conexao();

        static int guardarClique = 0;

        private void btnMostrarMedicos_Click(object sender, EventArgs e)
        {   
           try
           {
              if (guardarClique > 0)
              {
                 dtGV.DataSource = null;
                 string sql = "SELECT * FROM Medicos";
                 var dado = con.MostrarDados(sql);
                 dtGV.DataSource = dado;
              }

              else
              {
                 string sql = "SELECT * FROM Medicos";
                 var dado = con.MostrarDados(sql);
                 dtGV.DataSource = dado;
                 guardarClique++;
               }
           }

           catch (Exception ex)
           {
                MessageBox.Show("Ocorreu um erro: " + ex);
           }
        }

        private void btnMostrarPacientes_Click(object sender, EventArgs e)
        {
            try
            {
                if (guardarClique > 0 && txtIdPaciente.Text != "")
                {
                    dtGV.DataSource = null;
                    string sql = String.Format("SELECT * FROM Pacientes WHERE idPaciente = '{0}'", txtIdPaciente.Text);
                    var dado = con.MostrarDados(sql);
                    dtGV.DataSource = dado;
                    guardarClique++;
                }


                else if (txtIdPaciente.Text != "")
                {
                    string sql = String.Format("SELECT * FROM Pacientes WHERE idPaciente = '{0}'", txtIdPaciente.Text);
                    var dado = con.MostrarDados(sql);
                    dtGV.DataSource = dado;
                    guardarClique++;
                }

                else
                {
                    string sql = "SELECT * FROM Pacientes";
                    var dado = con.MostrarDados(sql);
                    dtGV.DataSource = dado;
                    guardarClique++;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }
        }

        private void btnMostrarConsultas_Click(object sender, EventArgs e)
        {
            try
            {
                if (guardarClique > 0)
                {
                    dtGV.DataSource = null;
                    string sql = "SELECT * FROM Consultas";
                    var dado = con.MostrarDados(sql);
                    dtGV.DataSource = dado;
                }

                else
                {
                    string sql = "SELECT * FROM Consultas";
                    var dado = con.MostrarDados(sql);
                    dtGV.DataSource = dado;
                    guardarClique++;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }
        }
    }
}
