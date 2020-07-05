namespace FormCampo
{
    partial class FormCampo
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.rtbSalidaDeTest = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(2, 3);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(794, 45);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "Mostrar estado";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // rtbSalidaDeTest
            // 
            this.rtbSalidaDeTest.Location = new System.Drawing.Point(8, 60);
            this.rtbSalidaDeTest.Name = "rtbSalidaDeTest";
            this.rtbSalidaDeTest.Size = new System.Drawing.Size(787, 385);
            this.rtbSalidaDeTest.TabIndex = 1;
            this.rtbSalidaDeTest.Text = "";
            // 
            // FormCampo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbSalidaDeTest);
            this.Controls.Add(this.btnMostrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCampo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Campo";
            this.Load += new System.EventHandler(this.FormCampo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.RichTextBox rtbSalidaDeTest;
    }
}

