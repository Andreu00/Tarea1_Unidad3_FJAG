﻿namespace Tarea1_Unidad3_FJAG
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
            this.btnCambiarFormato = new System.Windows.Forms.Button();
            this.txtAlarma = new System.Windows.Forms.TextBox();
            this.btnEstablecerAlarma = new System.Windows.Forms.Button();
            this.reloj1 = new Tarea1_Unidad3_FJAG.reloj();
            this.SuspendLayout();
            // 
            // btnCambiarFormato
            // 
            this.btnCambiarFormato.Location = new System.Drawing.Point(176, 243);
            this.btnCambiarFormato.Name = "btnCambiarFormato";
            this.btnCambiarFormato.Size = new System.Drawing.Size(151, 23);
            this.btnCambiarFormato.TabIndex = 1;
            this.btnCambiarFormato.Text = "Cambiar Formato 12h/24h";
            this.btnCambiarFormato.UseVisualStyleBackColor = true;
            this.btnCambiarFormato.Click += new System.EventHandler(this.btnCambiarFormato_Click);
            // 
            // txtAlarma
            // 
            this.txtAlarma.Location = new System.Drawing.Point(390, 243);
            this.txtAlarma.Name = "txtAlarma";
            this.txtAlarma.Size = new System.Drawing.Size(150, 20);
            this.txtAlarma.TabIndex = 2;
            // 
            // btnEstablecerAlarma
            // 
            this.btnEstablecerAlarma.Location = new System.Drawing.Point(546, 243);
            this.btnEstablecerAlarma.Name = "btnEstablecerAlarma";
            this.btnEstablecerAlarma.Size = new System.Drawing.Size(108, 23);
            this.btnEstablecerAlarma.TabIndex = 3;
            this.btnEstablecerAlarma.Text = "Establecer Alarma";
            this.btnEstablecerAlarma.UseVisualStyleBackColor = true;
            this.btnEstablecerAlarma.Click += new System.EventHandler(this.btnEstablecerAlarma_Click);
            // 
            // reloj1
            // 
            this.reloj1.AutoSize = true;
            this.reloj1.Font = new System.Drawing.Font("Microsoft Sans Serif", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloj1.Formato24Horas = false;
            this.reloj1.Location = new System.Drawing.Point(156, 120);
            this.reloj1.Name = "reloj1";
            this.reloj1.Size = new System.Drawing.Size(498, 120);
            this.reloj1.TabIndex = 0;
            this.reloj1.Text = "07:48:24 ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEstablecerAlarma);
            this.Controls.Add(this.txtAlarma);
            this.Controls.Add(this.btnCambiarFormato);
            this.Controls.Add(this.reloj1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private reloj reloj1;
        private System.Windows.Forms.Button btnCambiarFormato;
        private System.Windows.Forms.TextBox txtAlarma;
        private System.Windows.Forms.Button btnEstablecerAlarma;
    }
}

