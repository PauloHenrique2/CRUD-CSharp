namespace Hospital
{
    partial class FrmView
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
            this.btnMostrarPacientes = new System.Windows.Forms.Button();
            this.dtGV = new System.Windows.Forms.DataGridView();
            this.btnMostrarMedicos = new System.Windows.Forms.Button();
            this.btnMostrarConsultas = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visualizarDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.alterarERemoverDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMostrarPacientes
            // 
            this.btnMostrarPacientes.Location = new System.Drawing.Point(111, 330);
            this.btnMostrarPacientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarPacientes.Name = "btnMostrarPacientes";
            this.btnMostrarPacientes.Size = new System.Drawing.Size(94, 45);
            this.btnMostrarPacientes.TabIndex = 21;
            this.btnMostrarPacientes.Text = "Mostrar Dados (Pacientes)";
            this.btnMostrarPacientes.UseVisualStyleBackColor = true;
            this.btnMostrarPacientes.Click += new System.EventHandler(this.btnMostrarPacientes_Click);
            // 
            // dtGV
            // 
            this.dtGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGV.Location = new System.Drawing.Point(62, 42);
            this.dtGV.Margin = new System.Windows.Forms.Padding(2);
            this.dtGV.Name = "dtGV";
            this.dtGV.RowHeadersWidth = 51;
            this.dtGV.RowTemplate.Height = 24;
            this.dtGV.Size = new System.Drawing.Size(682, 184);
            this.dtGV.TabIndex = 20;
            // 
            // btnMostrarMedicos
            // 
            this.btnMostrarMedicos.Location = new System.Drawing.Point(354, 330);
            this.btnMostrarMedicos.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarMedicos.Name = "btnMostrarMedicos";
            this.btnMostrarMedicos.Size = new System.Drawing.Size(94, 45);
            this.btnMostrarMedicos.TabIndex = 22;
            this.btnMostrarMedicos.Text = "Mostrar Dados (Médicos)";
            this.btnMostrarMedicos.UseVisualStyleBackColor = true;
            this.btnMostrarMedicos.Click += new System.EventHandler(this.btnMostrarMedicos_Click);
            // 
            // btnMostrarConsultas
            // 
            this.btnMostrarConsultas.Location = new System.Drawing.Point(607, 330);
            this.btnMostrarConsultas.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarConsultas.Name = "btnMostrarConsultas";
            this.btnMostrarConsultas.Size = new System.Drawing.Size(94, 45);
            this.btnMostrarConsultas.TabIndex = 23;
            this.btnMostrarConsultas.Text = "Mostrar Dados (Consultas)";
            this.btnMostrarConsultas.UseVisualStyleBackColor = true;
            this.btnMostrarConsultas.Click += new System.EventHandler(this.btnMostrarConsultas_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarDadosToolStripMenuItem,
            this.alterarERemoverDadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "mnStrip";
            // 
            // visualizarDadosToolStripMenuItem
            // 
            this.visualizarDadosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.visualizarDadosToolStripMenuItem.Name = "visualizarDadosToolStripMenuItem";
            this.visualizarDadosToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.visualizarDadosToolStripMenuItem.Text = "Cadastrar";
            this.visualizarDadosToolStripMenuItem.Click += new System.EventHandler(this.visualizarDadosToolStripMenuItem_Click);
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.Location = new System.Drawing.Point(111, 282);
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.Size = new System.Drawing.Size(94, 20);
            this.txtIdPaciente.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Se desejar, insira o id do paciente";
            // 
            // alterarERemoverDadosToolStripMenuItem
            // 
            this.alterarERemoverDadosToolStripMenuItem.Name = "alterarERemoverDadosToolStripMenuItem";
            this.alterarERemoverDadosToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.alterarERemoverDadosToolStripMenuItem.Text = "Alterar e remover dados";
            this.alterarERemoverDadosToolStripMenuItem.Click += new System.EventHandler(this.alterarERemoverDadosToolStripMenuItem_Click);
            // 
            // FrmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnMostrarConsultas);
            this.Controls.Add(this.btnMostrarMedicos);
            this.Controls.Add(this.btnMostrarPacientes);
            this.Controls.Add(this.dtGV);
            this.Name = "FrmView";
            this.Text = "Hospital - Visualizar dados";
            ((System.ComponentModel.ISupportInitialize)(this.dtGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarPacientes;
        public System.Windows.Forms.DataGridView dtGV;
        private System.Windows.Forms.Button btnMostrarMedicos;
        private System.Windows.Forms.Button btnMostrarConsultas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visualizarDadosToolStripMenuItem;
        private System.Windows.Forms.TextBox txtIdPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem alterarERemoverDadosToolStripMenuItem;
    }
}