namespace Hospital
{
    partial class FrmUR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visualizarDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarERemoverDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdPaciente1 = new System.Windows.Forms.TextBox();
            this.btnRemoverPaciente = new System.Windows.Forms.Button();
            this.btnAlterardados = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdPaciente2 = new System.Windows.Forms.TextBox();
            this.txtTelPaciente = new System.Windows.Forms.MaskedTextBox();
            this.btnRemoverMedico = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdMedico1 = new System.Windows.Forms.TextBox();
            this.txtCRMMedico = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdMedico2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNomeMedico = new System.Windows.Forms.TextBox();
            this.btnAlterarDados2 = new System.Windows.Forms.Button();
            this.btnRemoverConsulta = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtidConsulta1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pacientes";
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
            this.menuStrip1.Size = new System.Drawing.Size(1067, 30);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "mnStrip";
            // 
            // visualizarDadosToolStripMenuItem
            // 
            this.visualizarDadosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.visualizarDadosToolStripMenuItem.Name = "visualizarDadosToolStripMenuItem";
            this.visualizarDadosToolStripMenuItem.Size = new System.Drawing.Size(86, 26);
            this.visualizarDadosToolStripMenuItem.Text = "Cadastrar";
            this.visualizarDadosToolStripMenuItem.Click += new System.EventHandler(this.visualizarDadosToolStripMenuItem_Click);
            // 
            // alterarERemoverDadosToolStripMenuItem
            // 
            this.alterarERemoverDadosToolStripMenuItem.Name = "alterarERemoverDadosToolStripMenuItem";
            this.alterarERemoverDadosToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.alterarERemoverDadosToolStripMenuItem.Text = "Visualizar dados";
            this.alterarERemoverDadosToolStripMenuItem.Click += new System.EventHandler(this.alterarERemoverDadosToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(468, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Médicos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(819, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Consultas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Insira o id do paciente";
            // 
            // txtIdPaciente1
            // 
            this.txtIdPaciente1.Location = new System.Drawing.Point(133, 135);
            this.txtIdPaciente1.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPaciente1.Name = "txtIdPaciente1";
            this.txtIdPaciente1.Size = new System.Drawing.Size(124, 22);
            this.txtIdPaciente1.TabIndex = 28;
            // 
            // btnRemoverPaciente
            // 
            this.btnRemoverPaciente.Location = new System.Drawing.Point(149, 178);
            this.btnRemoverPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoverPaciente.Name = "btnRemoverPaciente";
            this.btnRemoverPaciente.Size = new System.Drawing.Size(93, 49);
            this.btnRemoverPaciente.TabIndex = 30;
            this.btnRemoverPaciente.Text = "Remover paciente";
            this.btnRemoverPaciente.UseVisualStyleBackColor = true;
            this.btnRemoverPaciente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAlterardados
            // 
            this.btnAlterardados.Location = new System.Drawing.Point(149, 465);
            this.btnAlterardados.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterardados.Name = "btnAlterardados";
            this.btnAlterardados.Size = new System.Drawing.Size(93, 49);
            this.btnAlterardados.TabIndex = 31;
            this.btnAlterardados.Text = "Alterar dados";
            this.btnAlterardados.UseVisualStyleBackColor = true;
            this.btnAlterardados.Click += new System.EventHandler(this.btnAlterardados_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 321);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Insira o novo nome do paciente";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Location = new System.Drawing.Point(133, 353);
            this.txtNomePaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(124, 22);
            this.txtNomePaciente.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 396);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Insira o novo telefone do paciente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 261);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Insira o id do paciente";
            // 
            // txtIdPaciente2
            // 
            this.txtIdPaciente2.Location = new System.Drawing.Point(133, 293);
            this.txtIdPaciente2.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPaciente2.Name = "txtIdPaciente2";
            this.txtIdPaciente2.Size = new System.Drawing.Size(124, 22);
            this.txtIdPaciente2.TabIndex = 36;
            // 
            // txtTelPaciente
            // 
            this.txtTelPaciente.Location = new System.Drawing.Point(133, 433);
            this.txtTelPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelPaciente.Mask = "00000-0000";
            this.txtTelPaciente.Name = "txtTelPaciente";
            this.txtTelPaciente.Size = new System.Drawing.Size(124, 22);
            this.txtTelPaciente.TabIndex = 38;
            // 
            // btnRemoverMedico
            // 
            this.btnRemoverMedico.Location = new System.Drawing.Point(472, 178);
            this.btnRemoverMedico.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoverMedico.Name = "btnRemoverMedico";
            this.btnRemoverMedico.Size = new System.Drawing.Size(93, 49);
            this.btnRemoverMedico.TabIndex = 41;
            this.btnRemoverMedico.Text = "Remover médico";
            this.btnRemoverMedico.UseVisualStyleBackColor = true;
            this.btnRemoverMedico.Click += new System.EventHandler(this.btnRemoverMedico_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(446, 103);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 16);
            this.label8.TabIndex = 40;
            this.label8.Text = "Insira o id do médico";
            // 
            // txtIdMedico1
            // 
            this.txtIdMedico1.Location = new System.Drawing.Point(456, 135);
            this.txtIdMedico1.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdMedico1.Name = "txtIdMedico1";
            this.txtIdMedico1.Size = new System.Drawing.Size(124, 22);
            this.txtIdMedico1.TabIndex = 39;
            // 
            // txtCRMMedico
            // 
            this.txtCRMMedico.Location = new System.Drawing.Point(456, 433);
            this.txtCRMMedico.Margin = new System.Windows.Forms.Padding(4);
            this.txtCRMMedico.Mask = "000000";
            this.txtCRMMedico.Name = "txtCRMMedico";
            this.txtCRMMedico.Size = new System.Drawing.Size(124, 22);
            this.txtCRMMedico.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(446, 261);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 16);
            this.label9.TabIndex = 46;
            this.label9.Text = "Insira o id do médico";
            // 
            // txtIdMedico2
            // 
            this.txtIdMedico2.Location = new System.Drawing.Point(456, 293);
            this.txtIdMedico2.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdMedico2.Name = "txtIdMedico2";
            this.txtIdMedico2.Size = new System.Drawing.Size(124, 22);
            this.txtIdMedico2.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(421, 396);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 16);
            this.label10.TabIndex = 44;
            this.label10.Text = "Insira o novo CRM do médico";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(421, 321);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 16);
            this.label11.TabIndex = 43;
            this.label11.Text = "Insira o novo nome do médico";
            // 
            // txtNomeMedico
            // 
            this.txtNomeMedico.Location = new System.Drawing.Point(456, 353);
            this.txtNomeMedico.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeMedico.Name = "txtNomeMedico";
            this.txtNomeMedico.Size = new System.Drawing.Size(124, 22);
            this.txtNomeMedico.TabIndex = 42;
            // 
            // btnAlterarDados2
            // 
            this.btnAlterarDados2.Location = new System.Drawing.Point(472, 465);
            this.btnAlterarDados2.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterarDados2.Name = "btnAlterarDados2";
            this.btnAlterarDados2.Size = new System.Drawing.Size(93, 49);
            this.btnAlterarDados2.TabIndex = 48;
            this.btnAlterarDados2.Text = "Alterar dados";
            this.btnAlterarDados2.UseVisualStyleBackColor = true;
            this.btnAlterarDados2.Click += new System.EventHandler(this.btnAlterarDados2_Click);
            // 
            // btnRemoverConsulta
            // 
            this.btnRemoverConsulta.Location = new System.Drawing.Point(823, 178);
            this.btnRemoverConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoverConsulta.Name = "btnRemoverConsulta";
            this.btnRemoverConsulta.Size = new System.Drawing.Size(93, 49);
            this.btnRemoverConsulta.TabIndex = 51;
            this.btnRemoverConsulta.Text = "Remover consulta";
            this.btnRemoverConsulta.UseVisualStyleBackColor = true;
            this.btnRemoverConsulta.Click += new System.EventHandler(this.btnRemoverConsulta_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(797, 103);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 16);
            this.label12.TabIndex = 50;
            this.label12.Text = "Insira o id da consulta";
            // 
            // txtidConsulta1
            // 
            this.txtidConsulta1.Location = new System.Drawing.Point(807, 135);
            this.txtidConsulta1.Margin = new System.Windows.Forms.Padding(4);
            this.txtidConsulta1.Name = "txtidConsulta1";
            this.txtidConsulta1.Size = new System.Drawing.Size(124, 22);
            this.txtidConsulta1.TabIndex = 49;
            // 
            // FrmUR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnRemoverConsulta);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtidConsulta1);
            this.Controls.Add(this.btnAlterarDados2);
            this.Controls.Add(this.txtCRMMedico);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIdMedico2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNomeMedico);
            this.Controls.Add(this.btnRemoverMedico);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIdMedico1);
            this.Controls.Add(this.txtTelPaciente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIdPaciente2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomePaciente);
            this.Controls.Add(this.btnAlterardados);
            this.Controls.Add(this.btnRemoverPaciente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdPaciente1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUR";
            this.Text = "Alterar remover dados";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visualizarDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarERemoverDadosToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdPaciente1;
        private System.Windows.Forms.Button btnRemoverPaciente;
        private System.Windows.Forms.Button btnAlterardados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdPaciente2;
        private System.Windows.Forms.MaskedTextBox txtTelPaciente;
        private System.Windows.Forms.Button btnRemoverMedico;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdMedico1;
        private System.Windows.Forms.MaskedTextBox txtCRMMedico;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdMedico2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNomeMedico;
        private System.Windows.Forms.Button btnAlterarDados2;
        private System.Windows.Forms.Button btnRemoverConsulta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtidConsulta1;
    }
}