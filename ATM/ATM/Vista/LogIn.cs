using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ATM.Modelo;
using ATM.DAO;
using ATM.Vista;

namespace ATM.Vista
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Cajero cajero = new Cajero(1, 10000, 100);
            CajeroDAO cajeroDao = new CajeroDAO();
            cajeroDao.Agregar(cajero);
            
            Cliente cliente = new Cliente("Estudiante",1,"cristian", "dabrowski", "41840057", new DateTime(0), "mail", "1231234", "1231232", "123");
            cliente.ListaCuentas = new List<Cuenta>();
            Cuenta cuenta = new Cuenta();
            cuenta.Saldo = 1000;
            cuenta.TipoCuenta.NombreTipo = "CajaAhorro";
            cliente.ListaCuentas.Add(cuenta);
            Cuenta cuenta1 = new Cuenta();
            cuenta1.TipoCuenta.NombreTipo = "CuentaCorriente";
            cliente.ListaCuentas.Add(cuenta1);
            
            Menu menu = new Menu(cliente,cajero);
            menu.ShowDialog();
        }
    }
}
