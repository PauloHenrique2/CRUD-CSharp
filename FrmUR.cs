using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace Hospital
{
    public partial class FrmUR : Form
    {
        public FrmUR()
        {
            InitializeComponent();
        }

        conexao con = new conexao();
        BLL_Medico objBLLMedico = new BLL_Medico();
        BLL_Paciente objBLLPaciente = new BLL_Paciente();
        BLL_Consulta objBLLConsulta = new BLL_Consulta();
        DTO_Medico DTOMedico = new DTO_Medico();
        DTO_Paciente DTOPaciente = new DTO_Paciente();
        DTO_Consulta DTOConsulta = new DTO_Consulta();

        private void visualizarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm1 fr = new Frm1();
            fr.Show();
        }

        private void alterarERemoverDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmView fr = new FrmView();
            fr.Show();
        }

        private void btnAlterardados_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;

                if (txtNomePaciente.Text != "" && txtTelPaciente.Text != "" && txtIdPaciente2.Text != "")
                {
                    sql = String.Format("SELECT idPaciente FROM Pacientes WHERE idPaciente = '{0}';", txtIdPaciente2.Text);

                    if (con.verificaConsulta(sql) == true)
                    {
                        DTOPaciente.idpaciente = int.Parse(txtIdPaciente2.Text);
                        DTOPaciente.nomepaciente = txtNomePaciente.Text;
                        DTOPaciente.Telefone = txtTelPaciente.Text;
                        objBLLPaciente.AlterarPaciente(DTOPaciente);
                        txtIdPaciente2.Clear();
                        txtNomePaciente.Clear();
                        txtTelPaciente.Clear();
                        MessageBox.Show("Dados alterados com sucesso!");
                    }

                    else
                    {
                        MessageBox.Show("Erro: ", "Paciente não encontrado no sistema!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Verifique os campos!");
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;

                if (txtIdPaciente1.Text != "")
                {
                    sql = String.Format("SELECT idPaciente FROM Pacientes WHERE idPaciente = '{0}';", txtIdPaciente1.Text);

                    if (con.verificaConsulta(sql) == true)
                    {
                        int id = int.Parse(txtIdPaciente1.Text);
                        objBLLPaciente.ExcluirPaciente(id);
                        txtIdPaciente1.Clear();
                        MessageBox.Show("Dados removidos com sucesso!");
                    }

                    else
                    {
                        MessageBox.Show("Erro: ", "Paciente não encontrado no sistema!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Erro: ", "Insira o id do paciente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void btnRemoverMedico_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                if (txtIdMedico1.Text != "")
                {
                    sql = String.Format("SELECT idMedico FROM Medicos WHERE idMedico = '{0}';", txtIdMedico1.Text);

                    if (con.verificaConsulta(sql) == true)
                    {
                        int id = int.Parse(txtIdMedico1.Text);
                        objBLLMedico.ExcluirMedico(id);
                        txtIdMedico1.Clear();
                        MessageBox.Show("Dados removidos com sucesso!");
                    }

                    else
                    {
                        MessageBox.Show("Erro: ", "Médico não encontrado no sistema!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            catch (FormatException ex)
            {
                MessageBox.Show("Erro: " + ex, "Ocorreu um erro de formato: ", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }
        }

        private void btnAlterarDados2_Click(object sender, EventArgs e)
        {
            try
            {
                string sql;

                if (txtIdMedico2.Text != "" && txtNomeMedico.Text != "" && txtCRMMedico.Text != "")
                {
                    sql = String.Format("SELECT idMedico FROM Medicos WHERE idMedico = '{0}';", int.Parse(txtIdMedico2.Text));

                    if (con.verificaConsulta(sql) == true)
                    {
                        DTOMedico.idmedico = int.Parse(txtIdMedico2.Text);
                        DTOMedico.nomemedico = txtNomeMedico.Text;
                        DTOMedico.crm = int.Parse(txtCRMMedico.Text);
                        objBLLMedico.AlterarMedico(DTOMedico);
                        txtIdMedico2.Clear();
                        txtNomeMedico.Clear();
                        txtCRMMedico.Clear();
                        MessageBox.Show("Dados alterados com sucesso!");
                    }

                    else
                    {
                        MessageBox.Show("Erro: ", "Médico não encontrado no sistema!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            catch (FormatException ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Ocorreu um erro de formato: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoverConsulta_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                if (txtidConsulta1.Text != "")
                {
                    sql = string.Format("SELECT idConsulta FROM Consultas WHERE idConsulta = '{0}';", txtidConsulta1.Text);

                    if (con.verificaConsulta(sql) == true)
                    {
                        int id = int.Parse(txtidConsulta1.Text);
                        DTOConsulta.idconsulta = id;
                        objBLLConsulta.ExcluirConsulta(id);
                        txtidConsulta1.Clear();
                        MessageBox.Show("Dados removidos com sucesso!");
                    }

                    else
                    {
                        MessageBox.Show("Erro: ", "Consulta não encontrada no sistema!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Erro: ", "Insira o id da consulta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
       
            }

            catch (FormatException ex)
            {
                MessageBox.Show("Erro: " + ex, "Ocorreu um erro de formato!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Ocorreu um erro!" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
