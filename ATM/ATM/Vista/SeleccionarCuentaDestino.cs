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
    public partial class SeleccionarCuentaDestino : Form
    {
        private Operacion _operacion;
        private Cliente _clienteActual;
        public SeleccionarCuentaDestino(Operacion operacion, Cliente clienteActual)
        {
            InitializeComponent();
            _operacion = operacion;
            _clienteActual = clienteActual;
        }

        private void btnMismoBanco_Click(object sender, EventArgs e)
        {
            CuentaDestinoTerceros aux = new CuentaDestinoTerceros(_operacion, _clienteActual);
            aux.ShowDialog();
            Close();
        }

        private void btnOtroBanco_Click(object sender, EventArgs e)
        {
            CuentaDestinoTerceros aux = new CuentaDestinoTerceros(_operacion, _clienteActual);
            aux.ShowDialog();
            Close();
        }
    }
}
