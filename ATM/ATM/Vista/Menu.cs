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
    public partial class Menu : Form
    {
        private Cliente _clienteActual;
        private Cajero _cajero;

        public Menu(Cliente cliente, Cajero cajero)
        {
            InitializeComponent();
            lblUsuario.Text = cliente.Nombre;
            _clienteActual = cliente;
            _cajero = cajero;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExtraccion_Click(object sender, EventArgs e)
        {
            Operacion operacion = new Operacion();
            operacion.ComenzarOperacion(operacion,_cajero, "Extraccion");
            SeleccionarTipoCuentaPropia aux = new SeleccionarTipoCuentaPropia(operacion,_clienteActual);
            aux.ShowDialog();
            
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            Operacion operacion = new Operacion();
            operacion.ComenzarOperacion(operacion, _cajero, "Deposito");
            SeleccionarCuentaDestino aux = new SeleccionarCuentaDestino(operacion,_clienteActual);
            aux.ShowDialog();
            Close();
        }
        
        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            Operacion operacion = new Operacion();
            operacion.ComenzarOperacion(operacion, _cajero, "Transferencia");
            SeleccionarCuentaDestino aux = new SeleccionarCuentaDestino(operacion, _clienteActual);
            aux.ShowDialog();
            Close();
        }

        private void btnDepositoTerceros_Click(object sender, EventArgs e)
        {
            Operacion operacion = new Operacion();
            operacion.ComenzarOperacion(operacion, _cajero, "Deposito");
            CuentaDestinoTerceros aux = new CuentaDestinoTerceros(operacion, _clienteActual);
            aux.ShowDialog();
            Close();
        }
    }
}
