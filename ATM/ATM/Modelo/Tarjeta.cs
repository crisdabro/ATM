using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM.Modelo
{
    public class Tarjeta
    {
        private int _idTarjeta;
        private int _numeroTarjeta;
        private Persona _propietario;
        private DateTime _desde;
        private DateTime _vencimiento;
        private string _password;

        public Tarjeta(int idTarjeta, int numeroTarjeta, Persona propietario, DateTime desde, DateTime hasta, string password)
        {
            IdTarjeta = idTarjeta;
            NumeroTarjeta = numeroTarjeta;
            Propietario = propietario;
            Desde = desde;
            Vencimiento = hasta;
            Password = password;
        }

        public Tarjeta()
        {
            IdTarjeta = 0;
            NumeroTarjeta = 0;
            Propietario = null;
            Desde = DateTime.MinValue;
            Vencimiento = DateTime.MinValue;
            Password = "";
        }

        public int IdTarjeta
        {
            get { return _idTarjeta; }
            set { _idTarjeta = value; }
        }
        public int NumeroTarjeta
        {
            get { return _numeroTarjeta; }
            set { _numeroTarjeta = value; }
        }
        public Persona Propietario
        {
            get { return _propietario; }
            set { _propietario = value; }
        }
        public DateTime Desde
        {
            get { return _desde; }
            set { _desde = value; }
        }
        public DateTime Vencimiento
        {
            get { return _vencimiento; }
            set { _vencimiento = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
