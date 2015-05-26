using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ATM.Modelo;

namespace ATM.Tests
{
    [TestFixture]
    class TestCajero
    {
        private Cajero _cajero;


        [SetUp]
        public void SetUp()
        {
            _cajero = new Cajero(1, 5000, 500, 0, 200);
        }

        [Test]
        public void HayPapelDisponible()
        {
            Assert.IsTrue(_cajero.Papeldisponible > 0);
        }

        [Test]
        public void HayDineroDisponible()
        {
            Assert.IsTrue(_cajero.Dinerodisponible > 0);
        }

        [Test]
        public void QuedaEspacioParaDepositar()
        {
            Assert.IsTrue(_cajero.CantidadDepositosActuales < _cajero.LimiteDepositos);
        }
    }
}
