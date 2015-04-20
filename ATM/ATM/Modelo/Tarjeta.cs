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
        private string _desde;
        private string _hasta;
        private string _password;
        private int _cantidadExtracciones;
        private double _totalExtraido;

        public Tarjeta(int idTarjeta, int numeroTarjeta, Persona propietario, string desde, string hasta, string password, int cantidadExtracciones, double totalExtraido)
        {
            _idTarjeta = idTarjeta;
            _numeroTarjeta = numeroTarjeta;
            _propietario = propietario;
            _desde = desde;
            _hasta = hasta;
            _password = password;
            _cantidadExtracciones = cantidadExtracciones;
            _totalExtraido = totalExtraido;
        }

        public Tarjeta()
        {
            _idTarjeta = 0;
            _numeroTarjeta = 0;
            _propietario = null;
            _desde = "";
            _hasta = "";
            _password = "";
            _cantidadExtracciones = 0;
            _totalExtraido = 0.0;
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

        public string Desde
        {
            get { return _desde; }
            set { _desde = value; }
        }

        public string Vencimiento
        {
            get { return _hasta; }
            set { _hasta = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public int CantidadExtracciones
        {
            get { return _cantidadExtracciones; }
            set { _cantidadExtracciones = value; }
        }

        public double TotalExtraido
        {
            get { return _totalExtraido; }
            set { _totalExtraido = value; }
        }
    }
}
