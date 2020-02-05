namespace cajero_automatico
{
    partial class Form1
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
            this.btnretirar = new System.Windows.Forms.Button();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnretirar
            // 
            this.btnretirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretirar.Location = new System.Drawing.Point(33, 83);
            this.btnretirar.Name = "btnretirar";
            this.btnretirar.Size = new System.Drawing.Size(133, 50);
            this.btnretirar.TabIndex = 0;
            this.btnretirar.Text = "RETIRAR";
            this.btnretirar.UseVisualStyleBackColor = true;
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(13, 26);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(52, 13);
            this.lblcantidad.TabIndex = 1;
            this.lblcantidad.Text = "Cantidad:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(66, 23);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 20);
            this.txtcantidad.TabIndex = 2;
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(172, 26);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(70, 13);
            this.lblrespuesta.TabIndex = 3;
            this.lblrespuesta.Text = "Respuesta: ?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 212);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.btnretirar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Cajero Automatico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnretirar;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label lblrespuesta;
    }
}

