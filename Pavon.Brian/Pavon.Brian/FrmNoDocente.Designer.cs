﻿namespace Pavon.Brian
{
    partial class FrmNoDocente
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
            this.SuspendLayout();
            // 
            // cmbHoraSalida
            // 
            this.cmbHoraSalida.Size = new System.Drawing.Size(189, 24);
            // 
            // cmbCargo
            // 
            this.cmbCargo.Size = new System.Drawing.Size(189, 24);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(103, 9);
            // 
            // cmbHoraIngreso
            // 
            this.cmbHoraIngreso.Size = new System.Drawing.Size(189, 24);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cmbSexo
            // 
            this.cmbSexo.Size = new System.Drawing.Size(189, 24);
            // 
            // FrmNoDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 562);
            this.Name = "FrmNoDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Personal NO Docente";
            this.Load += new System.EventHandler(this.FrmNoDocente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}