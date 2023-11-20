namespace Hospital
{
    partial class FrmDGV
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
            this.btnMostrarMedicos = new System.Windows.Forms.Button();
            this.btnMostrarPacientes = new System.Windows.Forms.Button();
            this.btnMostrarConsultas = new System.Windows.Forms.Button();
            this.dtGV = new System.Windows.Forms.DataGridView();
            this.lbl = new System.Windows.Forms.Label();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarMedicos
            // 
            this.btnMostrarMedicos.Location = new System.Drawing.Point(115, 333);
            this.btnMostrarMedicos.Name = "btnMostrarMedicos";
            this.btnMostrarMedicos.Size = new System.Drawing.Size(116, 49);
            this.btnMostrarMedicos.TabIndex = 0;
            this.btnMostrarMedicos.Text = "Mostrar Dados (Médicos)";
            this.btnMostrarMedicos.UseVisualStyleBackColor = true;
            this.btnMostrarMedicos.Click += new System.EventHandler(this.btnMostrarMedicos_Click);
            // 
            // btnMostrarPacientes
            // 
            this.btnMostrarPacientes.Location = new System.Drawing.Point(334, 333);
            this.btnMostrarPacientes.Name = "btnMostrarPacientes";
            this.btnMostrarPacientes.Size = new System.Drawing.Size(116, 49);
            this.btnMostrarPacientes.TabIndex = 1;
            this.btnMostrarPacientes.Text = "Mostrar Dados (Pacientes)";
            this.btnMostrarPacientes.UseVisualStyleBackColor = true;
            this.btnMostrarPacientes.Click += new System.EventHandler(this.btnMostrarPacientes_Click);
            // 
            // btnMostrarConsultas
            // 
            this.btnMostrarConsultas.Location = new System.Drawing.Point(577, 333);
            this.btnMostrarConsultas.Name = "btnMostrarConsultas";
            this.btnMostrarConsultas.Size = new System.Drawing.Size(116, 49);
            this.btnMostrarConsultas.TabIndex = 2;
            this.btnMostrarConsultas.Text = "Mostrar Dados (Consultas)";
            this.btnMostrarConsultas.UseVisualStyleBackColor = true;
            this.btnMostrarConsultas.Click += new System.EventHandler(this.btnMostrarConsultas_Click);
            // 
            // dtGV
            // 
            this.dtGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGV.Location = new System.Drawing.Point(59, 24);
            this.dtGV.Name = "dtGV";
            this.dtGV.RowHeadersWidth = 51;
            this.dtGV.RowTemplate.Height = 24;
            this.dtGV.Size = new System.Drawing.Size(684, 222);
            this.dtGV.TabIndex = 3;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(288, 270);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(213, 16);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Se desejar , insira o id do paciente";
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.Location = new System.Drawing.Point(334, 289);
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.Size = new System.Drawing.Size(116, 22);
            this.txtIdPaciente.TabIndex = 5;
            // 
            // FrmDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 408);
            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.dtGV);
            this.Controls.Add(this.btnMostrarConsultas);
            this.Controls.Add(this.btnMostrarPacientes);
            this.Controls.Add(this.btnMostrarMedicos);
            this.Name = "FrmDGV";
            this.Text = "Hospital - Visualização de dados";
            ((System.ComponentModel.ISupportInitialize)(this.dtGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarMedicos;
        private System.Windows.Forms.Button btnMostrarPacientes;
        private System.Windows.Forms.Button btnMostrarConsultas;
        private System.Windows.Forms.DataGridView dtGV;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtIdPaciente;
    }
}