namespace Hospital
{
    partial class Frm1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadPaciente = new System.Windows.Forms.Button();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeMedico = new System.Windows.Forms.TextBox();
            this.btnCadMedico = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCadConsulta = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelPaciente = new System.Windows.Forms.MaskedTextBox();
            this.txtDataConsulta = new System.Windows.Forms.MaskedTextBox();
            this.txtHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.txtHoraFim = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visualizarDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCRMMedico = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.alterarERemoverDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadPaciente
            // 
            this.btnCadPaciente.Location = new System.Drawing.Point(72, 228);
            this.btnCadPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadPaciente.Name = "btnCadPaciente";
            this.btnCadPaciente.Size = new System.Drawing.Size(107, 49);
            this.btnCadPaciente.TabIndex = 0;
            this.btnCadPaciente.Text = "Cadastrar Paciente";
            this.btnCadPaciente.UseVisualStyleBackColor = true;
            this.btnCadPaciente.Click += new System.EventHandler(this.btnCadPaciente_Click);
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Location = new System.Drawing.Point(72, 108);
            this.txtNomePaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(107, 22);
            this.txtNomePaciente.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Insira o nome do paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Insira o telefone do paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Insira o CRM do Médico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Insira o nome do médico";
            // 
            // txtNomeMedico
            // 
            this.txtNomeMedico.Location = new System.Drawing.Point(331, 108);
            this.txtNomeMedico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeMedico.Name = "txtNomeMedico";
            this.txtNomeMedico.Size = new System.Drawing.Size(107, 22);
            this.txtNomeMedico.TabIndex = 8;
            // 
            // btnCadMedico
            // 
            this.btnCadMedico.Location = new System.Drawing.Point(331, 228);
            this.btnCadMedico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadMedico.Name = "btnCadMedico";
            this.btnCadMedico.Size = new System.Drawing.Size(107, 49);
            this.btnCadMedico.TabIndex = 6;
            this.btnCadMedico.Text = "Cadastrar Médico";
            this.btnCadMedico.UseVisualStyleBackColor = true;
            this.btnCadMedico.Click += new System.EventHandler(this.btnCadMedico_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(605, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Insira o horário de ínicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(600, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Insira a data da consulta";
            // 
            // btnCadConsulta
            // 
            this.btnCadConsulta.Location = new System.Drawing.Point(621, 297);
            this.btnCadConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadConsulta.Name = "btnCadConsulta";
            this.btnCadConsulta.Size = new System.Drawing.Size(108, 47);
            this.btnCadConsulta.TabIndex = 11;
            this.btnCadConsulta.Text = "Cadastrar Consulta";
            this.btnCadConsulta.UseVisualStyleBackColor = true;
            this.btnCadConsulta.Click += new System.EventHandler(this.btnCadConsulta_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(593, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Insira o horário de término";
            // 
            // txtTelPaciente
            // 
            this.txtTelPaciente.Location = new System.Drawing.Point(72, 185);
            this.txtTelPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelPaciente.Mask = "00000-0000";
            this.txtTelPaciente.Name = "txtTelPaciente";
            this.txtTelPaciente.Size = new System.Drawing.Size(107, 22);
            this.txtTelPaciente.TabIndex = 19;
            // 
            // txtDataConsulta
            // 
            this.txtDataConsulta.Location = new System.Drawing.Point(621, 75);
            this.txtDataConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDataConsulta.Mask = "0000-00-00";
            this.txtDataConsulta.Name = "txtDataConsulta";
            this.txtDataConsulta.Size = new System.Drawing.Size(107, 22);
            this.txtDataConsulta.TabIndex = 20;
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Location = new System.Drawing.Point(621, 134);
            this.txtHoraInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoraInicio.Mask = "00-00";
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(107, 22);
            this.txtHoraInicio.TabIndex = 21;
            // 
            // txtHoraFim
            // 
            this.txtHoraFim.Location = new System.Drawing.Point(621, 196);
            this.txtHoraFim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoraFim.Mask = "00-00";
            this.txtHoraFim.Name = "txtHoraFim";
            this.txtHoraFim.Size = new System.Drawing.Size(107, 22);
            this.txtHoraFim.TabIndex = 22;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarDadosToolStripMenuItem,
            this.alterarERemoverDadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 28);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "mnStrip";
            // 
            // visualizarDadosToolStripMenuItem
            // 
            this.visualizarDadosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.visualizarDadosToolStripMenuItem.Name = "visualizarDadosToolStripMenuItem";
            this.visualizarDadosToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.visualizarDadosToolStripMenuItem.Text = "Visualizar dados";
            this.visualizarDadosToolStripMenuItem.Click += new System.EventHandler(this.visualizarDadosToolStripMenuItem_Click);
            // 
            // txtCRMMedico
            // 
            this.txtCRMMedico.Location = new System.Drawing.Point(329, 185);
            this.txtCRMMedico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCRMMedico.Mask = "000000";
            this.txtCRMMedico.Name = "txtCRMMedico";
            this.txtCRMMedico.Size = new System.Drawing.Size(107, 22);
            this.txtCRMMedico.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(601, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Insira as observações";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(621, 252);
            this.txtObs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(107, 22);
            this.txtObs.TabIndex = 25;
            // 
            // alterarERemoverDadosToolStripMenuItem
            // 
            this.alterarERemoverDadosToolStripMenuItem.Name = "alterarERemoverDadosToolStripMenuItem";
            this.alterarERemoverDadosToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.alterarERemoverDadosToolStripMenuItem.Text = "Alterar e remover dados";
            this.alterarERemoverDadosToolStripMenuItem.Click += new System.EventHandler(this.alterarERemoverDadosToolStripMenuItem_Click);
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 357);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.txtCRMMedico);
            this.Controls.Add(this.txtHoraFim);
            this.Controls.Add(this.txtHoraInicio);
            this.Controls.Add(this.txtDataConsulta);
            this.Controls.Add(this.txtTelPaciente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCadConsulta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomeMedico);
            this.Controls.Add(this.btnCadMedico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomePaciente);
            this.Controls.Add(this.btnCadPaciente);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm1";
            this.Text = "Hospital";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadPaciente;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeMedico;
        private System.Windows.Forms.Button btnCadMedico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCadConsulta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtTelPaciente;
        private System.Windows.Forms.MaskedTextBox txtDataConsulta;
        private System.Windows.Forms.MaskedTextBox txtHoraInicio;
        private System.Windows.Forms.MaskedTextBox txtHoraFim;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visualizarDadosToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox txtCRMMedico;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.ToolStripMenuItem alterarERemoverDadosToolStripMenuItem;
    }
}

