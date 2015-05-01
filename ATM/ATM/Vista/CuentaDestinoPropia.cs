using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ATM.DAO;
using ATM.Modelo;

namespace ATM.Vista
{
    public partial class CuentaDestinoPropia : Form
    {
        private Operacion _operacion;
        private Cliente _clienteActual;
        CuentaDAO datosCuenta = new CuentaDAO();

        public CuentaDestinoPropia(Operacion operacion, Cliente clienteActual)
        {
            InitializeComponent();

            _operacion = operacion;
            _clienteActual = clienteActual;

            listBoxCuentasCliente.DataSource = clienteActual.ListaCuentas;
            listBoxCuentasCliente.DisplayMember = "Cbu";
            listBoxCuentasCliente.ValueMember = "Cbu";
        }

        private void CuentaDestinoMismoBanco_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            
            foreach (Cuenta cuenta in _clienteActual.ListaCuentas)
            {
                if ((Convert.ToInt32(listBoxCuentasCliente.SelectedValue)) == cuenta.Cbu)
                {
                    _operacion.Cuenta = cuenta;
                }
            }
            _operacion.Deposito(Convert.ToInt32(txtMontoDeposito.Text));
            FinalizacionOperacion aux = new FinalizacionOperacion(_operacion);
            aux.ShowDialog();
            Close();
        }



    }
}
