namespace ClinicaApp
{
    partial class TurnoActual
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
            this.txtHistorialTurnos = new System.Windows.Forms.RichTextBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHistorialTurnos
            // 
            this.txtHistorialTurnos.Location = new System.Drawing.Point(13, 22);
            this.txtHistorialTurnos.Name = "txtHistorialTurnos";
            this.txtHistorialTurnos.ReadOnly = true;
            this.txtHistorialTurnos.Size = new System.Drawing.Size(713, 290);
            this.txtHistorialTurnos.TabIndex = 0;
            this.txtHistorialTurnos.Text = "";
            // 
            // lblPaciente
            // 
            this.lblPaciente.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblPaciente.Location = new System.Drawing.Point(12, 338);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(318, 50);
            this.lblPaciente.TabIndex = 1;
            this.lblPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblEspecialidad.Location = new System.Drawing.Point(408, 338);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(318, 50);
            this.lblEspecialidad.TabIndex = 2;
            this.lblEspecialidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TurnoActual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClinicaApp.Properties.Resources.fondo2;
            this.ClientSize = new System.Drawing.Size(738, 397);
            this.ControlBox = false;
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.txtHistorialTurnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(1100, 500);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TurnoActual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TurnoActual";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtHistorialTurnos;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblEspecialidad;
    }
}