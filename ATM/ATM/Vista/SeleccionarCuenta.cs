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
    public partial class SeleccionarCuenta : Form
    {
        private Operacion _operacion;
        private Cliente _clienteactual;
        public SeleccionarCuenta(Operacion operacion, Cliente clienteActual)
        {
            InitializeComponent();
            _operacion = operacion;
            _clienteactual = clienteActual;
            
            //si es una extraccion mostrar cuentas propias
            //si es deposito mostrar todas
            //si es transferencia mostrar propias y en el boton llamar a este mismo form mostrando las cuentas de terceros
        }
        private void btnCajaAhorro_Click(object sender, EventArgs e)
        {
            _operacion.Cuenta = _clienteactual.ListaCuentas[0];//depsues hacer un find ?????????????????????????????
            ExtraccionIngresarMonto aux = new ExtraccionIngresarMonto(_operacion);
            Hide();
            aux.ShowDialog();
            
            
        }

        private void btnCtaCte_Click(object sender, EventArgs e)
        {
            _operacion.Cuenta = _clienteactual.ListaCuentas[1];//depsues hacer un find ??????????????????
            ExtraccionIngresarMonto aux = new ExtraccionIngresarMonto(_operacion);
            Hide();
            aux.ShowDialog();
        }
            
            
           
        
    }
}
