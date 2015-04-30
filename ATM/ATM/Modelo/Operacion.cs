using System;

namespace ATM.Modelo
{
    public class Operacion
    {
        private int _idOperacion;
        private DateTime _fecha;
        private double _monto;
        private Cajero _cajero;
        private string _cbuDestino;
        private Cuenta _cuenta;
        private TipoOperacion _tipoOperacion;

        public Operacion(int idOperacion, DateTime fecha, double monto, Cajero cajero, string cbuDestino, Cuenta cuenta, TipoOperacion tipo)
        {
            _idOperacion = idOperacion;
            _fecha = fecha;
            _monto = monto;
            _cajero = cajero;
            _cbuDestino = cbuDestino;
            _cuenta = cuenta;
            _tipoOperacion = tipo;
        }

        public Operacion()
        {
            _idOperacion = 0;
            _fecha = DateTime.MinValue;
            _monto = 0.0;
            _cajero = null; //hacer metodo get cajero
            _cbuDestino = null;
            _cuenta = null;
            _tipoOperacion = null;
        }

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }       

        public double Monto
        {
            get { return _monto; }
            set { _monto = value; }
        }

        public Cajero Cajero
        {
            get { return _cajero; }
            set { _cajero = value; }
        }


        public Cuenta Cuenta
        {
            get { return _cuenta; }
            set { _cuenta = value; }
        }

        public TipoOperacion TipoOperacion
        {
            get { return _tipoOperacion; }
            set { _tipoOperacion = value; }
        }

        public int IdOperacion
        {
            get { return _idOperacion; }
            set { _idOperacion = value; }
        }

        public string CbuDestino
        {
            get { return _cbuDestino; }
            set { _cbuDestino = value; }
        }

        public Operacion ComenzarOperacion(Operacion operacion, Cajero cajero, string tipooperacion)
        {
            operacion.TipoOperacion = new TipoOperacion();//por ahora despues hay q levantarla del dao dependiento el tipo
            operacion.TipoOperacion.Nombre = tipooperacion;
            operacion.TipoOperacion.Costo = 15;
            operacion.Cajero = cajero;
            
            return operacion;
        }
        public void Extraccion(int monto)
        {
            TipoOperacion.Nombre = "Extraccion";
            Monto = monto;
            if (Cuenta.Saldo >= monto)
            {
                Cuenta.Saldo -= monto;
            }
        }

        public void Deposito(int monto)
        {
            TipoOperacion.Nombre = "Deposito";
            Monto = monto;
            Cuenta.Saldo += monto;
        }

        public void Transferencia(int monto, int cbuDestino)
        {

        }

    }
}
