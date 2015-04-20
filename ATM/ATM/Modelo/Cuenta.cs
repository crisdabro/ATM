namespace ATM.Modelo
{
    public class Cuenta
    {
        private int _idCuenta;
        private int _cbu;
        private int _cantidadExtracciones;
        private double _totalExtraido;
        private TipoCuenta _tipoCuenta;
        private double _saldo;
        public Cuenta(double saldo,int idCuenta, int cbu, int cantidadExtracciones, double totalExtraido)
        {
            _saldo = saldo;
            _tipoCuenta = new TipoCuenta();
            _idCuenta = idCuenta;
            _cbu = cbu;
            _cantidadExtracciones = cantidadExtracciones;
            _totalExtraido = totalExtraido;
        }

        public Cuenta()
        {
            _saldo = 0;
            _tipoCuenta = new TipoCuenta();
            _idCuenta = 0;
            _cbu = 0;
            _cantidadExtracciones = 0;
            _totalExtraido = 0.0;
        }

        public int Cbu
        {
            get { return _cbu; }
            set { _cbu = value; }
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

        public int IdCuenta
        {
            get { return _idCuenta; }
            set { _idCuenta = value; }
        }

        public TipoCuenta TipoCuenta
        {
            get { return _tipoCuenta; }
            set { _tipoCuenta = value; }
        }

        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
    }
}
