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
    public partial class CuentaDestinoTerceros : Form
    {
        
        //private int _idcuentaDestino;
        //private string _banco;
        //private int _cbu;
        //private string _sucursal
        
        public CuentaDestinoTerceros(Operacion _operacion, Cliente _clienteActual)
        {
            InitializeComponent();
            if (_operacion.TipoOperacion.Nombre == "Transferencia")
            {
                lblSucursal.Visible = false;
                txtSucursal.Visible = false;
            }
        }

        private void btnRealizarDepositoTerceros_Click(object sender, EventArgs e)
        {
            //CuentaDestino _datosCuentaDestinoTerceros = new CuentaDestino(Convert.ToInt32(txtNumeroDeCuenta.Text), txtSucursal.Text, Convert.ToInt32(txtCBU), txtSucursal);
            //private int _idcuentaDestino;
            //private string _banco;
            //private int _cbu;
            //private string _sucursal
            Close();
        }



    }
}
