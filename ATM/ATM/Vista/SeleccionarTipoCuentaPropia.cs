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
    public partial class SeleccionarTipoCuentaPropia : Form
    {
        private Operacion _operacion;
        private Cliente _clienteActual;
        public SeleccionarTipoCuentaPropia(Operacion operacion, Cliente clienteActual)
        {
            InitializeComponent();
            _operacion = operacion;
            _clienteActual = clienteActual;
            
            //si es una extraccion mostrar cuentas propias
            //si es deposito mostrar todas
            //si es transferencia mostrar propias y en el boton llamar a este mismo form mostrando las cuentas de terceros
        }
        private void btnCajaAhorro_Click(object sender, EventArgs e)
        {
            foreach (Cuenta _datosCuenta in _clienteActual.ListaCuentas)
            {
                if (_datosCuenta.TipoCuenta.NombreTipo == "Caja Ahorro")
                {
                    _operacion.Cuenta = _datosCuenta;
                }
            }
            ExtraccionIngresarMonto aux = new ExtraccionIngresarMonto(_operacion);
            aux.ShowDialog();
            Close();
            
        }

        private void btnCtaCte_Click(object sender, EventArgs e)
        {
            foreach (Cuenta _datosCuenta in _clienteActual.ListaCuentas)
            {
                if (_datosCuenta.TipoCuenta.NombreTipo == "CtaCrt")
                {
                    _operacion.Cuenta = _datosCuenta;
                }
            }
            ExtraccionIngresarMonto aux = new ExtraccionIngresarMonto(_operacion);
            aux.ShowDialog();
            Close();
        }
            
            
           
        
    }
}
