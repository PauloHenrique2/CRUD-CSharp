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
            this.txtdataConsulta = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtTelPaciente = new System.Windows.Forms.MaskedTextBox();
            this.txtCRMMedico = new System.Windows.Forms.MaskedTextBox();
            this.txtHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.txtHoraTermino = new System.Windows.Forms.MaskedTextBox();
            this.mnStrip = new System.Windows.Forms.MenuStrip();
            this.visualizarDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadPaciente
            // 
            this.btnCadPaciente.Location = new System.Drawing.Point(102, 221);
            this.btnCadPaciente.Name = "btnCadPaciente";
            this.btnCadPaciente.Size = new System.Drawing.Size(107, 49);
            this.btnCadPaciente.TabIndex = 0;
            this.btnCadPaciente.Text = "Cadastrar";
            this.btnCadPaciente.UseVisualStyleBackColor = true;
            this.btnCadPaciente.Click += new System.EventHandler(this.btnCadPaciente_Click);
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Location = new System.Drawing.Point(102, 102);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(107, 22);
            this.txtNomePaciente.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Insira o nome do paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Insira o telefone do paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Insira o CRM do Médico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Insira o nome do médico";
            // 
            // txtNomeMedico
            // 
            this.txtNomeMedico.Location = new System.Drawing.Point(325, 102);
            this.txtNomeMedico.Name = "txtNomeMedico";
            this.txtNomeMedico.Size = new System.Drawing.Size(107, 22);
            this.txtNomeMedico.TabIndex = 8;
            // 
            // btnCadMedico
            // 
            this.btnCadMedico.Location = new System.Drawing.Point(325, 221);
            this.btnCadMedico.Name = "btnCadMedico";
            this.btnCadMedico.Size = new System.Drawing.Size(107, 49);
            this.btnCadMedico.TabIndex = 6;
            this.btnCadMedico.Text = "Cadastrar";
            this.btnCadMedico.UseVisualStyleBackColor = true;
            this.btnCadMedico.Click += new System.EventHandler(this.btnCadMedico_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Insira o horário de ínicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(526, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Insira a data da consulta";
            // 
            // btnCadConsulta
            // 
            this.btnCadConsulta.Location = new System.Drawing.Point(547, 317);
            this.btnCadConsulta.Name = "btnCadConsulta";
            this.btnCadConsulta.Size = new System.Drawing.Size(107, 49);
            this.btnCadConsulta.TabIndex = 11;
            this.btnCadConsulta.Text = "Cadastrar";
            this.btnCadConsulta.UseVisualStyleBackColor = true;
            this.btnCadConsulta.Click += new System.EventHandler(this.btnCadConsulta_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(517, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Insira o horário de término";
            // 
            // txtdataConsulta
            // 
            this.txtdataConsulta.Location = new System.Drawing.Point(547, 92);
            this.txtdataConsulta.Mask = "0000-00-00";
            this.txtdataConsulta.Name = "txtdataConsulta";
            this.txtdataConsulta.Size = new System.Drawing.Size(100, 22);
            this.txtdataConsulta.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(526, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Insira as observações";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(547, 277);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(107, 22);
            this.txtObs.TabIndex = 22;
            // 
            // txtTelPaciente
            // 
            this.txtTelPaciente.Location = new System.Drawing.Point(102, 178);
            this.txtTelPaciente.Mask = "000000000";
            this.txtTelPaciente.Name = "txtTelPaciente";
            this.txtTelPaciente.Size = new System.Drawing.Size(100, 22);
            this.txtTelPaciente.TabIndex = 24;
            // 
            // txtCRMMedico
            // 
            this.txtCRMMedico.Location = new System.Drawing.Point(325, 178);
            this.txtCRMMedico.Mask = "000000";
            this.txtCRMMedico.Name = "txtCRMMedico";
            this.txtCRMMedico.Size = new System.Drawing.Size(100, 22);
            this.txtCRMMedico.TabIndex = 25;
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Location = new System.Drawing.Point(547, 156);
            this.txtHoraInicio.Mask = "00:00";
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(107, 22);
            this.txtHoraInicio.TabIndex = 26;
            // 
            // txtHoraTermino
            // 
            this.txtHoraTermino.Location = new System.Drawing.Point(547, 221);
            this.txtHoraTermino.Mask = "00:00";
            this.txtHoraTermino.Name = "txtHoraTermino";
            this.txtHoraTermino.Size = new System.Drawing.Size(107, 22);
            this.txtHoraTermino.TabIndex = 27;
            // 
            // mnStrip
            // 
            this.mnStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mnStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarDadosToolStripMenuItem});
            this.mnStrip.Location = new System.Drawing.Point(0, 0);
            this.mnStrip.Name = "mnStrip";
            this.mnStrip.Size = new System.Drawing.Size(784, 28);
            this.mnStrip.TabIndex = 28;
            // 
            // visualizarDadosToolStripMenuItem
            // 
            this.visualizarDadosToolStripMenuItem.Name = "visualizarDadosToolStripMenuItem";
            this.visualizarDadosToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.visualizarDadosToolStripMenuItem.Text = "Visualizar dados";
            this.visualizarDadosToolStripMenuItem.Click += new System.EventHandler(this.visualizarDadosToolStripMenuItem_Click);
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 393);
            this.Controls.Add(this.txtHoraTermino);
            this.Controls.Add(this.txtHoraInicio);
            this.Controls.Add(this.txtCRMMedico);
            this.Controls.Add(this.txtTelPaciente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.txtdataConsulta);
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
            this.Controls.Add(this.mnStrip);
            this.MainMenuStrip = this.mnStrip;
            this.Name = "Frm1";
            this.Text = "Hospital - Cadastro";
            this.mnStrip.ResumeLayout(false);
            this.mnStrip.PerformLayout();
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
        private System.Windows.Forms.MaskedTextBox txtdataConsulta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.MaskedTextBox txtTelPaciente;
        private System.Windows.Forms.MaskedTextBox txtCRMMedico;
        private System.Windows.Forms.MaskedTextBox txtHoraInicio;
        private System.Windows.Forms.MaskedTextBox txtHoraTermino;
        private System.Windows.Forms.MenuStrip mnStrip;
        private System.Windows.Forms.ToolStripMenuItem visualizarDadosToolStripMenuItem;
    }
}

