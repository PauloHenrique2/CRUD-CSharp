using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using DTO;

namespace Hospital
{
    public partial class Frm1 : Form
    {
        conexao con = new conexao();
        BLL_Medico objBLLMedico = new BLL_Medico();
        BLL_Paciente objBLLPaciente = new BLL_Paciente();
        BLL_Consulta objBLLConsulta = new BLL_Consulta();
        DTO_Medico DTOMedico = new DTO_Medico();
        DTO_Paciente DTOPaciente = new DTO_Paciente();
        DTO_Consulta DTOConsulta = new DTO_Consulta();

        public Frm1()
        {
            InitializeComponent();
        }

        private void btnCadMedico_Click(object sender, EventArgs e)
        {
            if (txtNomeMedico.Text != "" && txtCRMMedico.Text != "")
            {
                try
                {
                    DTOMedico.nomemedico = txtNomeMedico.Text;
                    DTOMedico.crm = int.Parse(txtCRMMedico.Text);
                    objBLLMedico.InserirMedico(DTOMedico);
                    txtNomeMedico.Clear();
                    txtCRMMedico.Clear();
                    MessageBox.Show("Dados inseridos com sucesso!");
                }

                catch (FormatException ex)
                {
                    MessageBox.Show("Erro: " + ex, "Ocorreu um erro de formato: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex);
                }
            }
        }

        private void visualizarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmView fr = new FrmView();
            fr.Show();
        }

        private void btnCadPaciente_Click(object sender, EventArgs e)
        {
            if (txtNomePaciente.Text != "" && txtTelPaciente.Text != "")
            {
                try
                {
                    DTOPaciente.nomepaciente = txtNomePaciente.Text;
                    DTOPaciente.Telefone = txtTelPaciente.Text;
                    objBLLPaciente.InserirPaciente(DTOPaciente);
                    txtNomePaciente.Clear();
                    txtTelPaciente.Clear();
                    MessageBox.Show("Dados inseridos com sucesso!");
                }

                catch (FormatException ex)
                {
                    MessageBox.Show("Erro: " + ex, "Ocorreu um erro de formato: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex);
                }
            }
        }

        private void btnCadConsulta_Click(object sender, EventArgs e)
        {
            if (txtDataConsulta.Text != "" && txtHoraInicio.Text != "" && txtHoraFim.Text != "")
            {
                try
                {
                    DTOConsulta.dataconsulta = txtDataConsulta.Text;
                    DTOConsulta.horainicio = txtHoraInicio.Text;
                    DTOConsulta.horafim = txtHoraFim.Text;
                    DTOConsulta.Obs = txtObs.Text;
                    objBLLConsulta.InserirConsulta(DTOConsulta);
                    txtDataConsulta.Clear();
                    txtHoraInicio.Clear();
                    txtHoraFim.Clear();
                    txtObs.Clear();
                    MessageBox.Show("Dados inseridos com sucesso!");
                }

                catch (FormatException ex)
                {
                    MessageBox.Show("Erro: " + ex, "Ocorreu um erro de formato: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex);
                }
            }
        }

        private void alterarERemoverDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUR fr = new FrmUR();
            fr.Show();
        }
    }
}
