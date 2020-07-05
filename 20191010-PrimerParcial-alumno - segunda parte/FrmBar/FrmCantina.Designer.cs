namespace FrmBar
{
    partial class FrmCantina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCantina));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbBotellaTipo = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericContenido = new System.Windows.Forms.NumericUpDown();
            this.numericCapacidad = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.radioAgua = new System.Windows.Forms.RadioButton();
            this.radioCerveza = new System.Windows.Forms.RadioButton();
            this.barra = new ControlCantina.Barra();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericContenido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCapacidad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbBotellaTipo);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numericContenido);
            this.panel1.Controls.Add(this.numericCapacidad);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMarca);
            this.panel1.Controls.Add(this.radioAgua);
            this.panel1.Controls.Add(this.radioCerveza);
            this.panel1.Location = new System.Drawing.Point(8, 380);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 146);
            this.panel1.TabIndex = 0;
            // 
            // cmbBotellaTipo
            // 
            this.cmbBotellaTipo.FormattingEnabled = true;
            this.cmbBotellaTipo.Location = new System.Drawing.Point(397, 38);
            this.cmbBotellaTipo.Name = "cmbBotellaTipo";
            this.cmbBotellaTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbBotellaTipo.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(397, 107);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Botella Tipo";
            // 
            // numericContenido
            // 
            this.numericContenido.Location = new System.Drawing.Point(252, 107);
            this.numericContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericContenido.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericContenido.Name = "numericContenido";
            this.numericContenido.Size = new System.Drawing.Size(61, 20);
            this.numericContenido.TabIndex = 7;
            this.numericContenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericCapacidad
            // 
            this.numericCapacidad.Location = new System.Drawing.Point(161, 107);
            this.numericCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCapacidad.Name = "numericCapacidad";
            this.numericCapacidad.Size = new System.Drawing.Size(61, 20);
            this.numericCapacidad.TabIndex = 6;
            this.numericCapacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contenido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Capacidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(158, 38);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(155, 20);
            this.txtMarca.TabIndex = 2;
            // 
            // radioAgua
            // 
            this.radioAgua.AutoSize = true;
            this.radioAgua.Location = new System.Drawing.Point(20, 38);
            this.radioAgua.Name = "radioAgua";
            this.radioAgua.Size = new System.Drawing.Size(50, 17);
            this.radioAgua.TabIndex = 1;
            this.radioAgua.Text = "Agua";
            this.radioAgua.UseVisualStyleBackColor = true;
            // 
            // radioCerveza
            // 
            this.radioCerveza.AutoSize = true;
            this.radioCerveza.Checked = true;
            this.radioCerveza.Location = new System.Drawing.Point(20, 14);
            this.radioCerveza.Name = "radioCerveza";
            this.radioCerveza.Size = new System.Drawing.Size(64, 17);
            this.radioCerveza.TabIndex = 0;
            this.radioCerveza.TabStop = true;
            this.radioCerveza.Text = "Cerveza";
            this.radioCerveza.UseVisualStyleBackColor = true;
            // 
            // barra
            // 
            this.barra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra.BackgroundImage")));
            this.barra.Location = new System.Drawing.Point(8, 6);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(551, 368);
            this.barra.TabIndex = 1;
            // 
            // FrmCantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 529);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCantina";
            this.Text = "Cantina";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCantina_FormClosing);
            this.Load += new System.EventHandler(this.FrmCantina_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericContenido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCapacidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericContenido;
        private System.Windows.Forms.NumericUpDown numericCapacidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.RadioButton radioAgua;
        private System.Windows.Forms.RadioButton radioCerveza;
        private System.Windows.Forms.ComboBox cmbBotellaTipo;
        private System.Windows.Forms.Button btnAgregar;
        private ControlCantina.Barra barra;
    }
}

