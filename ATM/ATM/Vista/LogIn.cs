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
            //CREA DATOS DEL CAJERO EN EL QUE ESTAS PARADO
            CajeroDAO cajeroDao = new CajeroDAO();
            Cajero cajero = new Cajero(1, 175000, 100, 0, 200);
            cajeroDao.Agregar(cajero);

            //CREA TIPOS DE CUENTA
            //int idTipoCuenta, string nombretipo, double limiteDinero, int limiteCantidadExtracciones
            TipoCuentaDAO datosTipoCuentaDao = new TipoCuentaDAO();
            TipoCuenta tipoCuenta = new TipoCuenta(1, "CtaCrt", 8000, 8, 3000);//CREA TIPO DE CUENTA
            datosTipoCuentaDao.Agregar(tipoCuenta);
            tipoCuenta = new TipoCuenta(2, "Caja Ahorro", 3000, 5, 3000);
            datosTipoCuentaDao.Agregar(tipoCuenta);

            //CREA DATOS TARJETA PARA CLIENTE
            //int idTarjeta, int numeroTarjeta, Persona propietario, string desde, string hasta, string password
            //string nombre, string apellido, string dni, DateTime fechaNacimiento, string direccion, string telefono, string celular, string mail
            PersonaDAO datosPersonaDao = new PersonaDAO();
            Persona propietario = new Persona(1, "cristian", "dabrowski", "41840057", new DateTime(1993, 6, 10), "plumas verdes 69", "494-0180", "155-257752", "cristian@mail");
            datosPersonaDao.Agregar(propietario);

            TarjetaDAO datosTarjetaDao = new TarjetaDAO();
            Tarjeta tarjetaCliente1 = new Tarjeta(1, 10001, propietario, new DateTime(), new DateTime().AddMonths(8), "abc123");
            datosTarjetaDao.Agregar(tarjetaCliente1);
            
            //CREA DATOS DE CLIENTES Y SUS CUENTAS 
            //int idCliente, string situacionImpositiva, List<Cuenta> cuentasCliente, List<Tarjeta> tarjetasCliente, string nombre, string apellido, string dni, DateTime fechaNacimiento, string direccion, string telefono, string celular, string mail
            CuentaDAO datosCuentaDao = new CuentaDAO();
            Cuenta cuenta = new Cuenta(1, 100001, datosTipoCuentaDao.DameXId(1), 10000, 0, 0);
            datosCuentaDao.Agregar(cuenta);
            cuenta = new Cuenta(2, 100002, datosTipoCuentaDao.DameXId(2), 180000, 0, 0);
            datosCuentaDao.Agregar(cuenta);

            ClienteDAO datosClienteDao = new ClienteDAO();
            List<Cuenta> listaCuentasCliente = new List<Cuenta>(datosCuentaDao.DameAll());
            List<Tarjeta> listaTarjetasCliente = new List<Tarjeta>(datosTarjetaDao.DameAll());
            Cliente cliente = new Cliente(1, "Estudiante", listaCuentasCliente, listaTarjetasCliente, "cristian", "dabrowski", "41840057", new DateTime(1993, 6, 10), "plumas verdes 69", "494-0180", "155-257752", "cristian@mail");//CLIENTE 1
            datosClienteDao.Agregar(cliente);
            //Cliente cliente2 = new Cliente( 2, "Jefe", listaCuentasCliente, listaTarjetasCliente, "guido", "motumbo", "34552014", new DateTime(09-05-89), "rivadavia 3421", "473-9862", "155-801960", "guido@mail");//CLIENTE 2


            Menu menu = new Menu(cliente, cajero);
            menu.ShowDialog();
            Close();
        }
    }
}
