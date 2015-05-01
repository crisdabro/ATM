using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ATM.Modelo;

namespace ATM.Vista
{
    public partial class ImprimirOperacion : Form
    {
        public ImprimirOperacion(Operacion operacion)
        {
            InitializeComponent();
            if (operacion.Cuenta.TipoCuenta.NombreTipo == "CtaCrt")
            {
                lblMostrarMontoCtaCte.Text = operacion.Cuenta.Saldo.ToString();
                lblSaldoCtaCte.Visible = true;
                lblMostrarMontoCtaCte.Visible = true;
                lblMostrarMontoCajaAhorro.Visible = false;
                lblSaldoCajaAhorro.Visible = false;
            }
            else//si el TipoCuenta.NombreTipo en la Operacion es Caja Ahorro 
            {
                lblMostrarMontoCajaAhorro.Text = operacion.Cuenta.Saldo.ToString();
                lblSaldoCajaAhorro.Visible = true;
                lblMostrarMontoCajaAhorro.Visible = true;
                lblMostrarMontoCtaCte.Visible = false;
                lblSaldoCtaCte.Visible = false;
            }
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
