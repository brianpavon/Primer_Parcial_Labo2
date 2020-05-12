﻿using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pavon.Brian
{
    public partial class FrmNoDocente : FrmPersonal
    {
        Administrativo noDocente;
        public FrmNoDocente()
        {
            InitializeComponent();
            this.HabilitarHoras = false;
            this.ModificarTitulo = "Bienvenido al modulo de Alta del Personal No Docente";
            //this.BackColor = Color.BlueViolet;
            base.ModificarFondo(Color.BlueViolet);
        }
        

        /// <summary>
        /// 
        /// </summary>
        public Administrativo DevolverNoDocente
        {
            get
            {
                return this.noDocente;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(!(base.ValidarDatos()) || string.IsNullOrEmpty(cmbCargo.Text) || string.IsNullOrEmpty(cmbHoraIngreso.Text)
                || string.IsNullOrEmpty(cmbHoraSalida.Text))
            {
                base.MensajeError();
            }
            else
            {
                noDocente = new Administrativo(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text),
                                               base.ValidarSexo(cmbSexo.Text), DateTime.Parse(cmbHoraIngreso.Text),
                                               DateTime.Parse(cmbHoraSalida.Text), DevolverCargo(cmbCargo.Text));
                this.DialogResult = DialogResult.OK;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="cargo"></param>
        /// <returns></returns>
        public ECargo DevolverCargo(string cargo)
        {
            ECargo auxCargo = 0;
            switch(cargo)
            {
                case "Porteria":
                    auxCargo = ECargo.Porteria;
                    break;
                case "Secretaria":
                    auxCargo = ECargo.Secretaria;
                    break;
                case "Cocina":
                    auxCargo = ECargo.Cocina;
                    break;
                case "Direccion":
                    auxCargo = ECargo.Direccion;
                    break;
                case "Tesoreria":
                    auxCargo = ECargo.Tesoreria;
                    break;
            }
            return auxCargo;
        }
    }
}
