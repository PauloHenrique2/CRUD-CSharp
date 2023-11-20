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

namespace Hospital
{
    public partial class Frm1 : Form
    {
        conexao con = new conexao();

        public Frm1()
        {
            InitializeComponent();
        }

        private void btnCadMedico_Click(object sender, EventArgs e)
        {
                string sql;
                try
                {
                  if (txtNomeMedico.Text != "" && txtCRMMedico.Text != "")
                  {
                     sql = String.Format("INSERT INTO Medicos(nomeMedico, CRM) VALUES('{0}','{1}')", txtNomeMedico.Text, txtCRMMedico.Text);
                     con.executarComando(sql);
                     txtNomeMedico.Clear();
                     txtCRMMedico.Clear();
                     MessageBox.Show("Dados inseridos com sucesso!");
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

        private void btnCadConsulta_Click(object sender, EventArgs e)
        {
            string sql;

                try
                {
                  if (txtdataConsulta.Text != "" && txtHoraInicio.Text != "" && txtHoraTermino.Text != "" && txtObs.Text != "")
                  {
                     sql = String.Format("INSERT INTO Consultas(dataConsulta, horaInicio, horaFim, obs) VALUES('{0}','{1}', '{2}', '{3}')", txtdataConsulta.Text, txtHoraInicio.Text, txtHoraTermino.Text, txtObs.Text);
                     con.executarComando(sql);
                     txtdataConsulta.Clear();
                     txtHoraInicio.Clear();
                     txtHoraTermino.Clear();
                     txtObs.Clear();
                     MessageBox.Show("Dados inseridos com sucesso!");
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

        private void btnCadPaciente_Click(object sender, EventArgs e)
        {

            string sql;
            try
            {
              if (txtNomePaciente.Text != "" && txtTelPaciente.Text != "")
              {
                 sql = String.Format("INSERT INTO Pacientes(nomePaciente, telefone) VALUES('{0}','{1}')", txtNomePaciente.Text, txtTelPaciente.Text);
                 con.executarComando(sql);
                 txtNomePaciente.Clear();
                 txtTelPaciente.Clear();
                 MessageBox.Show("Dados inseridos com sucesso!");
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

        private void visualizarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDGV fr = new FrmDGV();
            fr.Show();
        }
    }
}
