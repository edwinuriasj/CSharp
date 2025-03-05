namespace PROGRAMA_DE_FRECUENCIA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.FRECUENCIA = new System.Windows.Forms.Button();
            this.LIMPIAR = new System.Windows.Forms.Button();
            this.CERRAR = new System.Windows.Forms.Button();
            this.txtfrec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.etresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FRECUENCIA
            // 
            this.FRECUENCIA.Location = new System.Drawing.Point(12, 226);
            this.FRECUENCIA.Name = "FRECUENCIA";
            this.FRECUENCIA.Size = new System.Drawing.Size(83, 23);
            this.FRECUENCIA.TabIndex = 0;
            this.FRECUENCIA.Text = "FRECUENCIA";
            this.FRECUENCIA.UseVisualStyleBackColor = true;
            this.FRECUENCIA.Click += new System.EventHandler(this.FRECUENCIA_Click);
            // 
            // LIMPIAR
            // 
            this.LIMPIAR.Location = new System.Drawing.Point(108, 226);
            this.LIMPIAR.Name = "LIMPIAR";
            this.LIMPIAR.Size = new System.Drawing.Size(75, 23);
            this.LIMPIAR.TabIndex = 1;
            this.LIMPIAR.Text = "LIMPIAR";
            this.LIMPIAR.UseVisualStyleBackColor = true;
            this.LIMPIAR.Click += new System.EventHandler(this.LIMPIAR_Click);
            // 
            // CERRAR
            // 
            this.CERRAR.Location = new System.Drawing.Point(197, 226);
            this.CERRAR.Name = "CERRAR";
            this.CERRAR.Size = new System.Drawing.Size(75, 23);
            this.CERRAR.TabIndex = 2;
            this.CERRAR.Text = "CERRAR";
            this.CERRAR.UseVisualStyleBackColor = true;
            this.CERRAR.Click += new System.EventHandler(this.CERRAR_Click);
            // 
            // txtfrec
            // 
            this.txtfrec.Location = new System.Drawing.Point(132, 66);
            this.txtfrec.Name = "txtfrec";
            this.txtfrec.Size = new System.Drawing.Size(100, 20);
            this.txtfrec.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "FRECUENCIA:";
            // 
            // etresultado
            // 
            this.etresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etresultado.Location = new System.Drawing.Point(12, 139);
            this.etresultado.Name = "etresultado";
            this.etresultado.Size = new System.Drawing.Size(260, 46);
            this.etresultado.TabIndex = 5;
            this.etresultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.etresultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfrec);
            this.Controls.Add(this.CERRAR);
            this.Controls.Add(this.LIMPIAR);
            this.Controls.Add(this.FRECUENCIA);
            this.Name = "Form1";
            this.Text = "FRECUENCIA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FRECUENCIA;
        private System.Windows.Forms.Button LIMPIAR;
        private System.Windows.Forms.Button CERRAR;
        private System.Windows.Forms.TextBox txtfrec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label etresultado;
    }
}

