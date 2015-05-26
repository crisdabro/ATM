using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ATM.Modelo;

namespace ATM.Tests
{
    [TestFixture]
    class TestDeposito
    {
        private Cajero _cajero;
        private Cuenta _cuenta;
        private Cliente _cliente;
        private Operacion _operacion;


        [SetUp]
        public void SetUp()
        {
            _cajero = new Cajero(1, 5000, 500, 0, 200);
            _cuenta = new Cuenta(1, 123456, new TipoCuenta(1, "cuenta corriente", 5000, 5, 3000), 2500, 0, 0);
            _cliente = new Cliente(1, "Estudiante", new List<Cuenta>(), new List<Tarjeta>(), "cristian", "dabrowski", "41840057",
                new DateTime(1993, 6, 10), "Tomas Guido 666", "494-0180", "155-257752", "cristian@mail.com");
            _cliente.ListaCuentas.Add(_cuenta);
            _operacion = new Operacion(1, new DateTime(2015, 5, 10), 3000, _cajero, null, _cuenta, new TipoOperacion(1, "Deposito", 0));
        }

        [Test]
        public void CuentaDestinoExiste()
        {
            Assert.IsTrue(false);
        }

        [Test]
        public void MontoEsNumerico()
        {
            Assert.IsTrue(_operacion.Monto.GetType() == Type.GetType("System.Double"));
        }

        [Test]
        public void MontoNoSuperaLimite()
        {
           Assert.IsTrue(_operacion.Monto <= _operacion.Cuenta.TipoCuenta.LimiteDeposito);
        }

        [Test]
        public void MontoEsPositivo()
        {
            Assert.IsTrue(_operacion.Monto > 0);
        }

        [Test]
        public void OperacionEsExtraccion()
        {
            Assert.IsTrue(_operacion.TipoOperacion.Nombre == "Deposito");
        }
    }
}