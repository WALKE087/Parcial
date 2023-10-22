namespace ParcialNomina
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbrirRegistroEmpleado = new System.Windows.Forms.Button();
            this.btnAbrirConsultaEmpleados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programa de Nominas";
            // 
            // btnAbrirRegistroEmpleado
            // 
            this.btnAbrirRegistroEmpleado.Location = new System.Drawing.Point(206, 178);
            this.btnAbrirRegistroEmpleado.Name = "btnAbrirRegistroEmpleado";
            this.btnAbrirRegistroEmpleado.Size = new System.Drawing.Size(141, 44);
            this.btnAbrirRegistroEmpleado.TabIndex = 1;
            this.btnAbrirRegistroEmpleado.Text = "Registrar Empleado";
            this.btnAbrirRegistroEmpleado.UseVisualStyleBackColor = true;
            this.btnAbrirRegistroEmpleado.Click += new System.EventHandler(this.btnAbrirRegistroEmpleado_Click);
            // 
            // btnAbrirConsultaEmpleados
            // 
            this.btnAbrirConsultaEmpleados.Location = new System.Drawing.Point(417, 178);
            this.btnAbrirConsultaEmpleados.Name = "btnAbrirConsultaEmpleados";
            this.btnAbrirConsultaEmpleados.Size = new System.Drawing.Size(141, 44);
            this.btnAbrirConsultaEmpleados.TabIndex = 2;
            this.btnAbrirConsultaEmpleados.Text = "Consultar Empleado";
            this.btnAbrirConsultaEmpleados.UseVisualStyleBackColor = true;
            this.btnAbrirConsultaEmpleados.Click += new System.EventHandler(this.btnAbrirConsultaEmpleados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAbrirConsultaEmpleados);
            this.Controls.Add(this.btnAbrirRegistroEmpleado);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbrirRegistroEmpleado;
        private System.Windows.Forms.Button btnAbrirConsultaEmpleados;
    }
}

