namespace ClinicaApp
{
    partial class ProximoTurno
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
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPaciente
            // 
            this.lblPaciente.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.ForeColor = System.Drawing.Color.Tomato;
            this.lblPaciente.Location = new System.Drawing.Point(12, 34);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(400, 50);
            this.lblPaciente.TabIndex = 0;
            this.lblPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.ForeColor = System.Drawing.Color.Tomato;
            this.lblEspecialidad.Location = new System.Drawing.Point(12, 106);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(400, 50);
            this.lblEspecialidad.TabIndex = 1;
            this.lblEspecialidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProximoTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClinicaApp.Properties.Resources.fondo2;
            this.ClientSize = new System.Drawing.Size(424, 185);
            this.ControlBox = false;
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.lblPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(1200, 200);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProximoTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Proximo Turno";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblEspecialidad;
    }
}