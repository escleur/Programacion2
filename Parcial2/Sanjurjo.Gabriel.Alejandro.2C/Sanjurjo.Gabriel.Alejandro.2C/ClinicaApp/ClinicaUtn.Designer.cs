namespace ClinicaApp
{
    partial class ClinicaUtn
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obraSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPacientes = new System.Windows.Forms.Label();
            this.lblEspecialistas = new System.Windows.Forms.Label();
            this.dgvEspecialistas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCrearTurno = new System.Windows.Forms.Button();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.txtEspecialista = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialistas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.AllowUserToOrderColumns = true;
            this.dgvPacientes.AllowUserToResizeRows = false;
            this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.clinic,
            this.apellido,
            this.nombre,
            this.edad,
            this.sexo,
            this.direccion,
            this.obraSocial});
            this.dgvPacientes.Location = new System.Drawing.Point(39, 46);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.RowHeadersVisible = false;
            this.dgvPacientes.Size = new System.Drawing.Size(796, 190);
            this.dgvPacientes.TabIndex = 1;
            this.dgvPacientes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacientes_RowEnter);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // clinic
            // 
            this.clinic.HeaderText = "Clinica";
            this.clinic.Name = "clinic";
            this.clinic.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // edad
            // 
            this.edad.HeaderText = "Edad";
            this.edad.Name = "edad";
            this.edad.ReadOnly = true;
            // 
            // sexo
            // 
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // obraSocial
            // 
            this.obraSocial.HeaderText = "Obra Social";
            this.obraSocial.Name = "obraSocial";
            this.obraSocial.ReadOnly = true;
            // 
            // lblPacientes
            // 
            this.lblPacientes.AutoSize = true;
            this.lblPacientes.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacientes.Location = new System.Drawing.Point(41, 13);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(86, 22);
            this.lblPacientes.TabIndex = 2;
            this.lblPacientes.Text = "Pacientes";
            // 
            // lblEspecialistas
            // 
            this.lblEspecialistas.AutoSize = true;
            this.lblEspecialistas.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialistas.Location = new System.Drawing.Point(41, 252);
            this.lblEspecialistas.Name = "lblEspecialistas";
            this.lblEspecialistas.Size = new System.Drawing.Size(112, 22);
            this.lblEspecialistas.TabIndex = 3;
            this.lblEspecialistas.Text = "Especialistas";
            // 
            // dgvEspecialistas
            // 
            this.dgvEspecialistas.AllowUserToAddRows = false;
            this.dgvEspecialistas.AllowUserToDeleteRows = false;
            this.dgvEspecialistas.AllowUserToOrderColumns = true;
            this.dgvEspecialistas.AllowUserToResizeRows = false;
            this.dgvEspecialistas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEspecialistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.especialidad});
            this.dgvEspecialistas.Location = new System.Drawing.Point(39, 287);
            this.dgvEspecialistas.Name = "dgvEspecialistas";
            this.dgvEspecialistas.ReadOnly = true;
            this.dgvEspecialistas.RowHeadersVisible = false;
            this.dgvEspecialistas.Size = new System.Drawing.Size(796, 190);
            this.dgvEspecialistas.TabIndex = 4;
            this.dgvEspecialistas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEspecialistas_RowEnter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Clinica";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Edad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Sexo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // especialidad
            // 
            this.especialidad.HeaderText = "Especialidad";
            this.especialidad.Name = "especialidad";
            this.especialidad.ReadOnly = true;
            // 
            // btnCrearTurno
            // 
            this.btnCrearTurno.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCrearTurno.Location = new System.Drawing.Point(705, 495);
            this.btnCrearTurno.Name = "btnCrearTurno";
            this.btnCrearTurno.Size = new System.Drawing.Size(120, 23);
            this.btnCrearTurno.TabIndex = 5;
            this.btnCrearTurno.Text = "Generar Turno";
            this.btnCrearTurno.UseVisualStyleBackColor = false;
            this.btnCrearTurno.Click += new System.EventHandler(this.btnCrearTurno_Click);
            // 
            // txtPaciente
            // 
            this.txtPaciente.Enabled = false;
            this.txtPaciente.Location = new System.Drawing.Point(41, 498);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(277, 20);
            this.txtPaciente.TabIndex = 6;
            // 
            // txtEspecialista
            // 
            this.txtEspecialista.Enabled = false;
            this.txtEspecialista.Location = new System.Drawing.Point(363, 498);
            this.txtEspecialista.Name = "txtEspecialista";
            this.txtEspecialista.Size = new System.Drawing.Size(277, 20);
            this.txtEspecialista.TabIndex = 7;
            // 
            // ClinicaUtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ClinicaApp.Properties.Resources.fondo2;
            this.ClientSize = new System.Drawing.Size(886, 544);
            this.Controls.Add(this.txtEspecialista);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.btnCrearTurno);
            this.Controls.Add(this.dgvEspecialistas);
            this.Controls.Add(this.lblEspecialistas);
            this.Controls.Add(this.lblPacientes);
            this.Controls.Add(this.dgvPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 200);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClinicaUtn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ClinicaUtn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClinicaUtn_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialistas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.Label lblPacientes;
        private System.Windows.Forms.Label lblEspecialistas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinic;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn obraSocial;
        private System.Windows.Forms.DataGridView dgvEspecialistas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidad;
        private System.Windows.Forms.Button btnCrearTurno;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.TextBox txtEspecialista;
    }
}

