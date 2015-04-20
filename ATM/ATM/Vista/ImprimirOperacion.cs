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
            lblMontoCajaAhorro.Text = operacion.Cuenta.Saldo.ToString();
        }
    }
}
