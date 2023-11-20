using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace Hospital
{
    public partial class FrmView : Form
    {
        public FrmView()
        {
            InitializeComponent();
        }

        static int guardarClique = 0;

        conexao con = new conexao();
        BLL_Medico objBLLMedico = new BLL_Medico();
        BLL_Consulta objBLLConsulta = new BLL_Consulta();
        BLL_Paciente objBLLPaciente = new BLL_Paciente();

        private void btnMostrarPacientes_Click(object sender, EventArgs e)
        {
            try
            {
                if (guardarClique > 0 && txtIdPaciente.Text != "")
                {
                    string sql = String.Format("SELECT idPaciente FROM Pacientes WHERE idPaciente = '{0}'", txtIdPaciente.Text);
                    if (con.verificaConsulta(sql) == true)
                    {
                        int id = int.Parse(txtIdPaciente.Text);
                        dtGV.DataSource = null;
                        var dado = objBLLPaciente.ExibirPacientesComId(id);
                        dtGV.DataSource = dado;
                        guardarClique++;
                    }

                    else
                    {
                        MessageBox.Show("Paciente não encontrado no sistema!", "Erro");
                    }
                }

                else if (txtIdPaciente.Text != "")
                {
                    string sql = String.Format("SELECT idPaciente FROM Pacientes WHERE idPaciente = '{0}'", txtIdPaciente.Text);

                    if (con.verificaConsulta(sql) == true)
                    {
                        int id = int.Parse(txtIdPaciente.Text);
                        var dado = objBLLPaciente.ExibirPacientesComId(id);
                        dtGV.DataSource = dado;
                        guardarClique++;
                    }

                    else
                    {
                        MessageBox.Show("Paciente não encontrado no sistema!", "Erro");
                    }
                }

                else
                {
                    var dado = objBLLPaciente.ExibirPacientes();
                    dtGV.DataSource = dado;
                    guardarClique++;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }
        }

        private void btnMostrarMedicos_Click(object sender, EventArgs e)
        {
            try
            {
                if (guardarClique > 0)
                {
                    dtGV.DataSource = null;
                    var dado = objBLLMedico.ExibirMedicos();
                    dtGV.DataSource = dado;
                    guardarClique++;
                }

                else
                {
                    var dado = objBLLMedico.ExibirMedicos();
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
                    var dado = objBLLConsulta.ExibirConsultas();
                    dtGV.DataSource = dado;
                    guardarClique++;
                }

                else
                {
                    var dado = objBLLConsulta.ExibirConsultas();
                    dtGV.DataSource = dado;
                    guardarClique++;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }
        }

        private void visualizarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm1 fr = new Frm1();
            fr.Show();
        }

        private void alterarERemoverDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUR fr = new FrmUR();
            fr.Show();
        }
    }
}
