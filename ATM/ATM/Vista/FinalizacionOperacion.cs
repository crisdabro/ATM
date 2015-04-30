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
    public partial class FinalizacionOperacion : Form
    {
        private Operacion _operacion;
        public FinalizacionOperacion(Operacion operacion)
        {
            InitializeComponent();
            _operacion = operacion;
        }

        private void FinalizacionOperacion__Load(object sender, EventArgs e)
        {

        }

        private void btnImprimirComprobante_Click(object sender, EventArgs e)
        {
            ImprimirOperacion aux = new ImprimirOperacion(_operacion);
            Hide();
            aux.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
