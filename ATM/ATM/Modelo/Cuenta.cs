namespace ATM.Modelo
{
    public class Cuenta
    {
        private int _idCuenta;
        private int _cbu;
        private TipoCuenta _tipoCuenta;
        private double _saldo;
        private int _cantidadExtraccionesDiario;
        private double _totalExtraidoDiario;
        
        public Cuenta()
        {
            IdCuenta = 0;
            Cbu = 0;
            TipoCuenta = new TipoCuenta();
            Saldo = 0;
            CantidadExtraccionesDiario = 0;
            TotalExtraidoDiario = 0.0;
        }

        public Cuenta(int idCuenta, int cbu, TipoCuenta tipoCuenta, double saldo, int cantidadExtracciones, double totalExtraido)
        {
            IdCuenta = idCuenta;
            Cbu = cbu;
            TipoCuenta = tipoCuenta;
            Saldo = saldo;
            CantidadExtraccionesDiario = cantidadExtracciones;
            TotalExtraidoDiario = totalExtraido;
        }

        public int IdCuenta
        {
            get { return _idCuenta; }
            set { _idCuenta = value; }
        }
        public int Cbu
        {
            get { return _cbu; }
            set { _cbu = value; }
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
        public int CantidadExtraccionesDiario
        {
            get { return _cantidadExtraccionesDiario; }
            set { _cantidadExtraccionesDiario = value; }
        }
        public double TotalExtraidoDiario
        {
            get { return _totalExtraidoDiario; }
            set { _totalExtraidoDiario = value; }
        }
    }
}
