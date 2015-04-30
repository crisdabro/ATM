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
    public partial class ExtraccionIngresarMonto : Form
    {
        private Operacion _operacion;
        public ExtraccionIngresarMonto(Operacion operacion)
        {
            InitializeComponent();
            _operacion = operacion;
            btnMonto100.Click += btnExtraccion_Click;
            btnMonto200.Click += btnExtraccion_Click;
            btnMonto500.Click += btnExtraccion_Click;
            btnMonto1000.Click += btnExtraccion_Click;
            btnMonto2000.Click += btnExtraccion_Click;
            btnMonto3000.Click += btnExtraccion_Click;
        }
        
        private void btnExtraccion_Click(object sender, EventArgs e) //manejo todos los botones desde aca
        {
            var btn = (Button) sender;
            _operacion.Extraccion(Convert.ToInt32(btn.Text));
            FinalizacionOperacion aux = new FinalizacionOperacion(_operacion);
            Hide();
            aux.Show();
        }
    }
}
